using System;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin.Edit {
    public partial class GroupEditForm : CustomForm {

        private Group _group;
        private CuAction _action;

        public GroupEditForm(Group group, CuAction action) {
            InitializeComponent();
            _group = group;
            _action = action;
        }

        private void RoleEditForm_Load(object sender, EventArgs e) {
            Program.Client.Connection.Send(new Packet10UnitList());
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _group.Name;
            }
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text)
                || unitBox.SelectedIndex < 0) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Group group = new Group {
                Name = nameBox.Text,
                Unit = (Unit) unitBox.SelectedItem
            };
            if (_action != CuAction.Create) {
                group.ID = _group.ID;
            }
            Program.Client.Connection.Send(new Packet9GroupEdit(group, _action));
            Close();
        }

        public void SelectUnit() {
            if (_action == CuAction.Create) {
                return;
            }
            unitBox.SelectedItem = _group.Unit;
        }

        private void GroupEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.Client.Connection.Send(new Packet8GroupList(null));
        }
    }
}
