using System;
using System.Windows.Forms;
using WarehouseClient.Properties;

namespace WarehouseClient.Forms.Authorization {
    public partial class ChangeServerForm : CustomForm {

        public ChangeServerForm() {
            InitializeComponent();
        }

        private void ChangeServerForm_Load(object sender, EventArgs e) {
            serverBox.Text = Settings.Default.Server;
        }

        private void changeButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(serverBox.Text)) {
                MessageBox.Show("Сервер не может быть таким.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Settings.Default.Server = serverBox.Text;
            Settings.Default.Save();
            Close();
        }
    }
}
