using System;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin.Edit {
    public partial class UnitEditForm : CustomForm {

        private Unit _unit;
        private CuAction _action;

        public UnitEditForm(Unit unit, CuAction action) {
            InitializeComponent();
            _unit = unit;
            _action = action;
        }

        private void RoleEditForm_Load(object sender, EventArgs e) {
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _unit.Name;
            }
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text)) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Unit unit = new Unit {
                Name = nameBox.Text
            };
            if (_action != CuAction.Create) {
                unit.ID = _unit.ID;
            }
            Program.Client.Connection.Send(new Packet11UnitEdit(unit, _action));
            Close();
        }

        private void UnitEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.Client.Connection.Send(new Packet10UnitList());
        }
    }
}
