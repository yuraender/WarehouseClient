using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Properties;

namespace WarehouseClient.Forms {
    public partial class SettingsForm : CustomForm {
        public SettingsForm() {
            InitializeComponent();
            CenterToParent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            fontBox.Text = Settings.Default.Font.Name + " " + Settings.Default.Font.Size;
            folderBox.Text = !Settings.Default.Folder.Equals("")
                ? Settings.Default.Folder
                : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void fontButton_Click(object sender, EventArgs e) {
            DialogResult result = fontDialog.ShowDialog();
            if (result != DialogResult.Cancel) {
                Settings.Default.Font
                    = new Font(fontDialog.Font.FontFamily, fontDialog.Font.Size);
                Settings.Default.Save();
                fontBox.Text = Settings.Default.Font.Name + " " + Settings.Default.Font.Size;

                List<CustomForm> forms = Application.OpenForms.Cast<Form>()
                    .Where(f => f is CustomForm).Cast<CustomForm>().ToList();
                foreach (CustomForm form in forms) {
                    form.ApplyFont();
                }
            }
        }

        private void folderButton_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result != DialogResult.Cancel) {
                Settings.Default.Folder = folderBrowserDialog.SelectedPath;
                Settings.Default.Save();
                folderBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
