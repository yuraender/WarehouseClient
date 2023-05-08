using CredentialManagement;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WarehouseClient.PacketsApi.Packets;
using WarehouseClient.Properties;

namespace WarehouseClient.Forms.Authorization {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            string logins = Settings.Default.Logins;
            foreach (string login in logins.Split(',')) {
                loginBox.Items.Add(login);
            }
            if (loginBox.Items.Count != 0) {
                loginBox.SelectedIndex = 0;
            }
        }

        private void loginBox_SelectedIndexChanged(object sender, EventArgs e) {
            using (Credential credential = new Credential()) {
                credential.Target = "WarehouseClient:" + loginBox.Text;
                if (credential.Exists()) {
                    credential.Load();
                    passwordBox.Text = credential.Password;
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(loginBox.Text)
                || string.IsNullOrEmpty(passwordBox.Text)) {
                MessageBox.Show("Введите имя пользователя и пароль.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Program.Client != null && Program.Client.Connection != null) {
                Program.Client.Connection.Send(new Packet1Login(loginBox.Text, passwordBox.Text));
            }
        }

        private void serverLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new ChangeServerForm().ShowDialog();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) {
            Process.GetCurrentProcess().Kill();
        }
    }
}
