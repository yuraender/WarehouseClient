using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet12Log : PacketBase {

        private readonly DateTime _from;
        private readonly DateTime _to;

        public Packet12Log(DateTime from, DateTime to) : base(12) {
            _from = from;
            _to = to;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(_from.ToString("dd.MM.yyyy 00:00:00"));
            writer.Write(_to.ToString("dd.MM.yyyy 23:59:59"));
        }
    }

    public class Packet12LogHandler : PacketHandlerBase {

        private List<string> _logs;

        public override void Read(BinaryReader reader) {
            _logs = JsonConvert.DeserializeObject<List<string>>(reader.ReadString());
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            ListBox logBox = (ListBox) form.Controls["logBox"];
            ComboBox packetBox = (ComboBox) form.Controls["packetBox"];
            form.Invoke(new Action(() => {
                if (packetBox.SelectedIndex > 0) {
                    logBox.DataSource = _logs
                        .Where(l => l.Contains((string) packetBox.SelectedItem))
                        .ToList();
                } else {
                    logBox.DataSource = _logs;
                }
            }));
        }

        public override object Clone() {
            return new Packet12LogHandler();
        }
    }
}
