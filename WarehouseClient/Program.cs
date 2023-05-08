using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WarehouseClient.Client;
using WarehouseClient.Forms.Authorization;
using WarehouseClient.Properties;
using static System.Windows.Forms.Control;

namespace WarehouseClient {
    public static class Program {

        private static Client.WarehouseClient _client;
        public static Client.WarehouseClient Client {
            get {
                bool retry = true;
                while (_client == null && retry) {
                    try {
                        string ip = Settings.Default.Server.Split(':')[0];
                        int port = int.Parse(Settings.Default.Server.Split(':')[1]);
                        _client = new Client.WarehouseClient(ip, port, new ClientHandler());
                    } catch {
                        DialogResult result = MessageBox.Show(
                            "Не удалось подключиться к серверу.", "",
                            MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        retry = result == DialogResult.Retry;
                    }
                }
                return _client;
            }
        }

        [STAThread]
        public static void Main() {
            using (Mutex mutex = new Mutex(false, "Global\\" + Assembly
                .GetExecutingAssembly().GetCustomAttribute<GuidAttribute>().Value)) {
                if (!mutex.WaitOne(0, false)) {
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());
            }
        }

        public static void SetAllControlsFont(ControlCollection controls) {
            foreach (Control control in controls) {
                if (control.Controls != null) {
                    SetAllControlsFont(control.Controls);
                }
                control.Font = Settings.Default.Font;
            }
        }
    }

    public enum Entities {

        Users, Parts, Groups, Units
    }

    public enum CuAction {

        Create, Update, Delete
    }
}
