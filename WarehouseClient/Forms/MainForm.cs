using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms.Admin;
using WarehouseClient.Forms.Admin.Edit;
using WarehouseClient.Forms.Requests;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms {
    public partial class MainForm : CustomForm {

        public User User {
            get; private set;
        }

        public MainForm(User user) {
            InitializeComponent();
            User = user;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            if (User.IsAdmin) {
                requestsMenuItem.Enabled = true;
                adminMenuItem.Visible = true;
                logMenuItem.Enabled = true;
                usersMenuItem.Enabled = true;
                partsMenuItem.Enabled = true;
                groupsMenuItem.Enabled = true;
                unitsMenuItem.Enabled = true;
            } else if (User.IsUnitAdmin) {
                adminMenuItem.Visible = true;
                partsMenuItem.Enabled = true;
            }
            Program.Client.Connection.Send(new Packet10UnitList());

            while (!User.IsPasswordChanged) {
                MessageBox.Show("Вам необходимо поменять пароль.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordMenuItem_Click(null, null);
            }
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e) {
            searchButton_Click(null, null);
        }

        private void unitBox_SelectedIndexChanged(object sender, EventArgs e) {
            Unit unit = unitBox.SelectedIndex > 0 ? (Unit) unitBox.SelectedItem : null;
            Program.Client.Connection.Send(new Packet8GroupList(unit));
        }

        private void partGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (partGridView.CurrentRow == null) {
                return;
            }
            Part part = (Part) partGridView.CurrentRow.DataBoundItem;
            if (part != null) {
                Program.Client.Connection.Send(new Packet6RepairList(part));
            }
        }

        public void searchButton_Click(object sender, EventArgs e) {
            if (groupBox.Items.Count == 0 || unitBox.Items.Count == 0) {
                return;
            }
            Group group = groupBox.SelectedIndex > 0 ? (Group) groupBox.SelectedItem : null;
            Unit unit = unitBox.SelectedIndex > 0 ? (Unit) unitBox.SelectedItem : null;
            Program.Client.Connection.Send(
                new Packet4PartList(searchBox.Text, repairNowCheck.Checked, repairOldCheck.Checked,
                group, unit));
        }

        private void writeOffButton_Click(object sender, EventArgs e) {
            if (partGridView.CurrentRow == null) {
                return;
            }
            Part part = (Part) partGridView.CurrentRow.DataBoundItem;
            if (part != null) {
                new PartWriteOffForm(part, User).Show(this);
            }
        }

        private void requestsMenuItem_Click(object sender, EventArgs e) {
            new RequestForm().Show(this);
        }

        private void passwordMenuItem_Click(object sender, EventArgs e) {
            new UserEditForm(User, CuAction.Update, false).ShowDialog();
        }

        private void settingsMenuItem_Click(object sender, EventArgs e) {
            new SettingsForm().ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e) {
            MainForm_FormClosed(null, null);
        }

        private void logMenuItem_Click(object sender, EventArgs e) {
            new LogForm().Show(this);
        }

        private void usersMenuItem_Click(object sender, EventArgs e) {
            if (!Application.OpenForms.Cast<Form>()
                .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                .Any(f => f.Type == Entities.Users)) {
                new EntityForm(usersMenuItem.Text, Entities.Users, User).Show(this);
            }
        }

        private void partsMenuItem_Click(object sender, EventArgs e) {
            if (!Application.OpenForms.Cast<Form>()
                .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                .Any(f => f.Type == Entities.Parts)) {
                new EntityForm(partsMenuItem.Text, Entities.Parts, User).Show(this);
            }
        }

        private void groupsMenuItem_Click(object sender, EventArgs e) {
            if (!Application.OpenForms.Cast<Form>()
                .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                .Any(f => f.Type == Entities.Groups)) {
                new EntityForm(groupsMenuItem.Text, Entities.Groups, User).Show(this);
            }
        }

        private void unitsMenuItem_Click(object sender, EventArgs e) {
            if (!Application.OpenForms.Cast<Form>()
                .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                .Any(f => f.Type == Entities.Units)) {
                new EntityForm(unitsMenuItem.Text, Entities.Units, User).Show(this);
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e) {
            new AboutForm().ShowDialog();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            partGridView.AutoResizeColumns();
            repairGridView.AutoResizeColumns();
        }

        private void timer_Tick(object sender, EventArgs e) {
            bool enabled = Application.OpenForms.Cast<Form>().Count(f => f is EntityForm) == 0;
            groupBox.Enabled = unitBox.Enabled = searchButton.Enabled = enabled;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Process.GetCurrentProcess().Kill();
        }
    }
}
