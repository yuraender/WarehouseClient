using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms;
using WarehouseClient.Forms.Admin.Edit;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Utils;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet6RepairList : PacketBase {

        private readonly Part _part;

        public Packet6RepairList(Part part) : base(6) {
            _part = part;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_part));
        }
    }

    public class Packet6RepairListHandler : PacketHandlerBase {

        private List<Repair> _repairs;

        public override void Read(BinaryReader reader) {
            _repairs = JsonConvert.DeserializeObject<List<Repair>>(reader.ReadString());
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            DataGridView repairGridView = (DataGridView) form.Controls["repairGridView"];
            ListBox repairBox = (ListBox) form.Controls["repairBox"];
            form.Invoke(new Action(() => {
                if (form is MainForm) {
                    repairGridView.Columns.Clear();
                    repairGridView.DataSource = new SortableBindingList<Repair>(_repairs);
                    repairGridView.Columns["Organization"].HeaderText = "Организация";
                    repairGridView.Columns["DispatchDate"].HeaderText = "Дата отправки";
                    repairGridView.Columns["ReturnDate"].HeaderText = "Дата возврата";
                    repairGridView.AutoResizeColumns();
                } else if (form is PartEditForm) {
                    repairBox.DataSource = _repairs;
                }
            }));
        }

        public override object Clone() {
            return new Packet6RepairListHandler();
        }
    }
}
