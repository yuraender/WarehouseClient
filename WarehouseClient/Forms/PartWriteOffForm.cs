using System;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms {
    public partial class PartWriteOffForm : CustomForm {

        private readonly Part _part;
        private readonly User _user;

        public PartWriteOffForm(Part part, User user) {
            InitializeComponent();
            _part = part;
            _user = user;
        }

        private void PartWriteOffForm_Load(object sender, EventArgs e) {
            CenterToParent();
            partBox.Text = $"{_part.Name} {_part.Type} (#{_part.ID})";
            unitBox.Enabled = _user.IsAdmin;
            Program.Client.Connection.Send(new Packet10UnitList());
        }

        private void writeOffButton_Click(object sender, EventArgs e) {
            if (unitBox.SelectedIndex < 0
                || !int.TryParse(amountBox.Text, out int amount)
                || amount < 1) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (amount > _part.Amount) {
                MessageBox.Show("Недостаточно деталей на складе.", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.Client.Connection.Send(new Packet13PartWriteOff(_part, amount, reasonBox.Text));
            Close();
        }

        public void SelectUnit() {
            if (_user.Unit == null) {
                return;
            }
            unitBox.SelectedItem = _user.Unit;
        }

        private void PartWriteOffForm_FormClosed(object sender, FormClosedEventArgs e) {
            MainForm form = (MainForm) Application.OpenForms["MainForm"];
            form.searchButton_Click(null, null);
        }
    }
}
