using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin.Edit {
    public partial class PartEditForm : CustomForm {

        private Part _part;
        private Unit _unit;
        private CuAction _action;

        public PartEditForm(Part part, Unit unit, CuAction action) {
            InitializeComponent();
            _part = part;
            _unit = unit;
            _action = action;
        }

        private void PartEditForm_Load(object sender, EventArgs e) {
            Program.Client.Connection.Send(new Packet8GroupList(_unit));
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
                measureBox.SelectedIndex = 0;
                repairCreateButton.Enabled = false;
                repairUpdateButton.Enabled = false;
                repairDeleteButton.Enabled = false;
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _part.Name;
                typeBox.Text = _part.Type;
                amountBox.Text = _part.Amount.ToString();
                measureBox.SelectedItem = _part.Measure;
                descriptionBox.Text = _part.Description;
                if (!((MainForm) Application.OpenForms["MainForm"]).User.IsAdmin) {
                    nameBox.Enabled = false;
                    typeBox.Enabled = false;
                    groupBox.Enabled = false;
                }
            }
            Program.Client.Connection.Send(new Packet6RepairList(_part));
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text)
                || string.IsNullOrEmpty(typeBox.Text)
                || !int.TryParse(amountBox.Text, out int amount) || amount < 1
                || measureBox.SelectedIndex < 0
                || groupBox.SelectedIndex < 0) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Part part = new Part {
                Name = nameBox.Text,
                Type = typeBox.Text,
                Amount = amount,
                Measure = measureBox.Text,
                Description = descriptionBox.Text,
                Group = (Group) groupBox.SelectedItem
            };
            if (_action != CuAction.Create) {
                part.ID = _part.ID;
            }
            Program.Client.Connection.Send(new Packet5PartEdit(part, _action));
            Close();
        }

        private void repairCreateButton_Click(object sender, EventArgs e) {
            new RepairEditForm(null, _part, CuAction.Create).ShowDialog();
        }

        private void repairUpdateButton_Click(object sender, EventArgs e) {
            Repair repair = (Repair) repairBox.SelectedItem;
            if (repair != null) {
                new RepairEditForm(repair, _part, CuAction.Update).ShowDialog();
            }
        }

        private void repairDeleteButton_Click(object sender, EventArgs e) {
            Repair repair = (Repair) repairBox.SelectedItem;
            if (repair == null) {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Будут удалены все сущности, ссылающиеся на эту запись."
                + "\nВы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result != DialogResult.OK) {
                return;
            }
            Program.Client.Connection.Send(new Packet7RepairEdit(repair, _part, CuAction.Delete));
            Thread.Sleep(1000);
            Program.Client.Connection.Send(new Packet6RepairList(_part));
        }

        public void SelectGroup() {
            if (_action == CuAction.Create) {
                return;
            }
            groupBox.SelectedItem = _part.Group;
        }

        private void PartEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            User user = ((MainForm) Application.OpenForms["MainForm"]).User;
            if (!user.IsAdmin) {
                Program.Client.Connection.Send(new Packet4PartList("", false, false, null, user.Unit));
            } else {
                Program.Client.Connection.Send(new Packet4PartList("", false, false, null, null));
            }
        }
    }
}
