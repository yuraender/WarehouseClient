using System;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin.Edit {
    public partial class RepairEditForm : CustomForm {

        private Repair _repair;
        private Part _part;
        private CuAction _action;

        public RepairEditForm(Repair repair, Part part, CuAction action) {
            InitializeComponent();
            _repair = repair;
            _part = part;
            _action = action;
        }

        private void PartEditForm_Load(object sender, EventArgs e) {
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                organizationBox.Text = _repair.Organization;
                dispatchDatePicker.Value = _repair.DispatchDate;
                if (_repair.ReturnDate.HasValue) {
                    returnDatePicker.Value = _repair.ReturnDate.Value;
                    returnDatePicker.Checked = true;
                }
            }
            if (_part != null) {
                partBox.Text = $"{_part.Name} {_part.Type}";
            }
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(organizationBox.Text)) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Repair repair = new Repair {
                Organization = organizationBox.Text,
                DispatchDate = dispatchDatePicker.Value
            };
            if (_action != CuAction.Create) {
                repair.ID = _repair.ID;
            }
            if (returnDatePicker.Checked) {
                repair.ReturnDate = returnDatePicker.Value;
            }

            Program.Client.Connection.Send(new Packet7RepairEdit(repair, _part, _action));
            Close();
        }

        private void RepairEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            Program.Client.Connection.Send(new Packet6RepairList(_part));
        }
    }
}
