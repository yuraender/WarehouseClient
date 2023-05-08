using CredentialManagement;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms;
using WarehouseClient.Forms.Authorization;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Properties;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet1Login : PacketBase {

        private readonly string _login;
        private readonly string _password;

        public Packet1Login(string login, string password) : base(1) {
            _login = login;
            _password = password;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(_login);
            writer.Write(_password);
        }
    }

    public class Packet1LoginHandler : PacketHandlerBase {

        private User _user;

        public override void Read(BinaryReader reader) {
            _user = JsonConvert.DeserializeObject<User>(reader.ReadString());
        }

        public override void Handle() {
            if (_user != null) {
                LoginForm loginForm = (LoginForm) Application.OpenForms["LoginForm"];
                loginForm.Invoke(new Action(() => {
                    if (((CheckBox) loginForm.Controls["rememberBox"]).Checked) {
                        using (Credential credential = new Credential()) {
                            string logins =  Settings.Default.Logins;
                            if (!logins.Split(',').ToList().Contains(_user.Login)) {
                                if (!string.IsNullOrEmpty(logins)) {
                                    Settings.Default.Logins = logins + "," + _user.Login;
                                    Settings.Default.Save();
                                } else {
                                    Settings.Default.Logins = _user.Login;
                                    Settings.Default.Save();
                                }
                            }

                            credential.Username = _user.Login;
                            credential.Password = loginForm.Controls["passwordBox"].Text;
                            credential.Target = "WarehouseClient:" + credential.Username;
                            credential.Type = CredentialType.Generic;
                            credential.PersistanceType = PersistanceType.LocalComputer;
                            credential.Save();
                        }
                    }

                    loginForm.Hide();
                    MainForm mainForm = new MainForm(_user);
                    mainForm.Closed += (sender, e) => loginForm.Close();
                    mainForm.Show();
                }));
            } else {
                MessageBox.Show("Неверное имя пользователя или пароль.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override object Clone() {
            return new Packet1LoginHandler();
        }
    }
}
