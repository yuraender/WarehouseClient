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
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Utils;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet10UnitList : PacketBase {
        public Packet10UnitList() : base(10) {
        }
    }

    public class Packet10UnitListHandler : PacketHandlerBase {

        private List<Unit> _units;

        public override void Read(BinaryReader reader) {
            _units = JsonConvert.DeserializeObject<List<Unit>>(reader.ReadString());
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            if (form is EntityForm) {
                form = Application.OpenForms.Cast<Form>()
                    .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                    .Where(f => f.Type == Entities.Units).First();
            }
            ComboBox unitBox = (ComboBox) form.Controls["unitBox"];
            DataGridView dataGridView = (DataGridView) form.Controls["dataGridView"];
            form.Invoke(new Action(() => {
                if (form is MainForm) {
                    User user = ((MainForm) form).User;
                    unitBox.Items.Clear();
                    if (!user.IsAdmin && user.Unit == null) {
                        return;
                    }
                    if (user.IsAdmin) {
                        unitBox.Items.Add("(не выбрано)");
                    }
                    foreach (Unit unit in _units) {
                        if (!user.IsAdmin && !unit.Equals(user.Unit)) {
                            continue;
                        }
                        unitBox.Items.Add(unit);
                    }
                    if (unitBox.Items.Count != 0) {
                        unitBox.SelectedIndex = 0;
                    }
                } else if (form is PartWriteOffForm) {
                    unitBox.Items.Clear();
                    foreach (Unit unit in _units) {
                        unitBox.Items.Add(unit);
                    }
                    if (unitBox.Items.Count != 0) {
                        unitBox.SelectedIndex = 0;
                    }
                    ((PartWriteOffForm) form).SelectUnit();
                } else if (form is EntityForm) {
                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = new SortableBindingList<Unit>(_units);
                    dataGridView.Columns["ID"].Width = 50;
                    dataGridView.Columns["Name"].HeaderText = "Название";
                } else if (form is UserEditForm) {
                    unitBox.Items.Clear();
                    unitBox.Items.Add("(не выбрано)");
                    foreach (Unit unit in _units) {
                        unitBox.Items.Add(unit);
                    }
                    unitBox.SelectedIndex = 0;
                    ((UserEditForm) form).SelectUnit();
                } else if (form is GroupEditForm) {
                    unitBox.Items.Clear();
                    foreach (Unit unit in _units) {
                        unitBox.Items.Add(unit);
                    }
                    if (unitBox.Items.Count != 0) {
                        unitBox.SelectedIndex = 0;
                    }
                    ((GroupEditForm) form).SelectUnit();
                }
            }));
        }

        public override object Clone() {
            return new Packet10UnitListHandler();
        }
    }
}
