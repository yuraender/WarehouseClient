using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms;
using WarehouseClient.Forms.Admin;
using WarehouseClient.Forms.Requests;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Utils;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet4PartList : PacketBase {

        private readonly string _name;
        private readonly bool _isInRepair;
        private readonly bool _wasInRepair;
        private readonly Group _group;
        private readonly Unit _unit;

        public Packet4PartList(string name,
            bool isInRepair, bool wasInRepair, Group group, Unit unit) : base(4) {
            _name = name;
            _isInRepair = isInRepair;
            _wasInRepair = wasInRepair;
            _group = group;
            _unit = unit;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(_name);
            writer.Write(_isInRepair);
            writer.Write(_wasInRepair);
            writer.Write(JsonConvert.SerializeObject(_group));
            writer.Write(JsonConvert.SerializeObject(_unit));
        }
    }

    public class Packet4PartListHandler : PacketHandlerBase {

        private List<Part> _parts;

        public override void Read(BinaryReader reader) {
            _parts = JsonConvert.DeserializeObject<List<Part>>(reader.ReadString());
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            if (form is EntityForm) {
                form = Application.OpenForms.Cast<Form>()
                    .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                    .Where(f => f.Type == Entities.Parts).First();
            }
            if (Application.OpenForms["RequestEditForm"] != null
                && Application.OpenForms["RequestPartEditForm"] == null) {
                form = Application.OpenForms["MainForm"];
            }
            DataGridView partGridView = (DataGridView) form.Controls["partGridView"];
            DataGridView repairGridView = (DataGridView) form.Controls["repairGridView"];
            DataGridView dataGridView = (DataGridView) form.Controls["dataGridView"];
            form.Invoke(new Action(() => {
                if (form is MainForm || form is EntityForm) {
                    DataGridView gridView = form is MainForm ? partGridView : dataGridView;
                    gridView.Columns.Clear();
                    gridView.DataSource = new SortableBindingList<Part>(_parts);
                    gridView.Columns["ID"].Width = 50;
                    gridView.Columns["Name"].HeaderText = "Наименование";
                    gridView.Columns["Type"].HeaderText = "Тип";
                    gridView.Columns["Amount"].HeaderText = "Количество";
                    gridView.Columns["Measure"].Visible = false;
                    gridView.Columns["Description"].HeaderText = "Описание";
                    gridView.Columns["Group"].HeaderText = "Группа";
                    gridView.Columns["Group"].DisplayIndex = 3;
                    gridView.AutoResizeColumns();

                    if (form is MainForm) {
                        ComboBox searchBox = (ComboBox) form.Controls["searchBox"];
                        repairGridView.Columns.Clear();
                        repairGridView.DataSource = null;
                        searchBox.Items.Clear();
                        foreach (DataGridViewRow row in partGridView.Rows) {
                            string name = (string) row.Cells[1].Value;
                            if (searchBox.Items.Contains(name)) {
                                continue;
                            }
                            searchBox.Items.Add(name);
                        }
                    }
                } else if (form is RequestPartEditForm) {
                    ComboBox partBox = (ComboBox) form.Controls["partBox"];
                    partBox.Items.Clear();
                    partBox.Items.Add("(свой вариант)");
                    foreach (Part part in _parts) {
                        partBox.Items.Add(part);
                    }
                    partBox.SelectedIndex = 0;
                }
            }));
        }

        public override object Clone() {
            return new Packet4PartListHandler();
        }
    }
}
