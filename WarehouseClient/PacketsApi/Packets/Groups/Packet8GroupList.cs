using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms;
using WarehouseClient.Forms.Admin;
using WarehouseClient.Forms.Admin.Edit;
using WarehouseClient.Forms.Requests;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Utils;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet8GroupList : PacketBase {

        private readonly Unit _unit;

        public Packet8GroupList(Unit unit) : base(8) {
            _unit = unit;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_unit));
        }
    }

    public class Packet8GroupListHandler : PacketHandlerBase {

        private List<Group> _groups;

        public override void Read(BinaryReader reader) {
            _groups = JsonConvert.DeserializeObject<List<Group>>(reader.ReadString());
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            if (form is EntityForm) {
                form = Application.OpenForms.Cast<Form>()
                    .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                    .Where(f => f.Type == Entities.Groups).First();
            }
            ComboBox groupBox = (ComboBox) form.Controls["groupBox"];
            DataGridView dataGridView = (DataGridView) form.Controls["dataGridView"];
            form.Invoke(new Action(() => {
                if (form is MainForm) {
                    groupBox.Items.Clear();
                    groupBox.Items.Add("(не выбрано)");
                    foreach (Group group in _groups) {
                        groupBox.Items.Add(group);
                    }
                    groupBox.SelectedIndex = 0;
                } else if (form is RequestPartEditForm) {
                    groupBox.Items.Clear();
                    foreach (Group group in _groups) {
                        groupBox.Items.Add(group);
                    }
                    ((RequestPartEditForm) form).SelectGroup();
                } else if (form is EntityForm) {
                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = new SortableBindingList<Group>(_groups);
                    dataGridView.Columns["ID"].Width = 50;
                    dataGridView.Columns["Name"].HeaderText = "Название";
                    dataGridView.Columns["Unit"].HeaderText = "Подразделение";
                } else if (form is PartEditForm) {
                    groupBox.Items.Clear();
                    foreach (Group group in _groups) {
                        groupBox.Items.Add(group);
                    }
                    if (groupBox.Items.Count != 0) {
                        groupBox.SelectedIndex = 0;
                    }
                    ((PartEditForm) form).SelectGroup();
                }
            }));
        }

        public override object Clone() {
            return new Packet8GroupListHandler();
        }
    }
}
