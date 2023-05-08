using System;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin.Edit {
    public partial class UserEditForm : CustomForm {

        private User _user;
        private CuAction _action;
        private bool _adminDialog;

        public UserEditForm(User user, CuAction action, bool adminDialog) {
            InitializeComponent();
            _user = user;
            _action = action;
            _adminDialog = adminDialog;
        }

        private void PartEditForm_Load(object sender, EventArgs e) {
            Program.Client.Connection.Send(new Packet10UnitList());
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _user.Name;
                loginBox.Text = _user.Login;
                adminBox.Checked = _user.IsAdmin;

                if (((MainForm) Application.OpenForms["MainForm"]).User.ID == _user.ID) {
                    adminBox.Enabled = false;
                }
            }
            if (!_adminDialog) {
                nameBox.Enabled = false;
                loginBox.Enabled = false;
                unitBox.Enabled = false;
                adminBox.Enabled = false;
                unitAdminBox.Enabled = false;
            }
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text)
                || string.IsNullOrEmpty(loginBox.Text)
                || (!_adminDialog && string.IsNullOrEmpty(passwordBox.Text))) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = new Random().Next(0, 1000000).ToString("D6");
            User user = new User {
                Name = nameBox.Text,
                Login = loginBox.Text,
                Password = _action == CuAction.Create ? password : passwordBox.Text,
                IsAdmin = adminBox.Checked,
                IsUnitAdmin = unitAdminBox.Checked,
                Unit = unitBox.SelectedIndex != 0 ? (Unit) unitBox.SelectedItem : null
            };
            if (!_adminDialog) {
                _user.IsPasswordChanged = user.IsPasswordChanged = true;
            } else if (!string.IsNullOrEmpty(passwordBox.Text)) {
                user.IsPasswordChanged = false;
            }
            if (_action != CuAction.Create) {
                user.ID = _user.ID;
            } else {
                MessageBox.Show($"Пароль пользователя — {password}", "",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Program.Client.Connection.Send(new Packet3UserEdit(user, _action));
            Close();
        }

        private void unitBox_SelectedIndexChanged(object sender, EventArgs e) {
            unitAdminBox.Enabled = unitBox.SelectedIndex != 0;
            unitAdminBox.Checked = false;
        }

        public void SelectUnit() {
            if (_action == CuAction.Create || _user.Unit == null) {
                return;
            }
            unitBox.SelectedItem = _user.Unit;
            unitAdminBox.Checked = _user.IsUnitAdmin;
        }

        private void UserEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.Client.Connection.Send(new Packet2UserList());
        }
    }
}
