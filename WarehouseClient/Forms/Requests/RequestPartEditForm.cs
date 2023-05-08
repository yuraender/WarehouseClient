using System;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms.Admin.Edit;
using WarehouseClient.PacketsApi.Packets;
using WarehouseClient.Utils;

namespace WarehouseClient.Forms.Requests {
    public partial class RequestPartEditForm : CustomForm {

        private RequestPart _requestPart;
        private CuAction _action;

        public RequestPartEditForm(RequestPart requestPart, CuAction action) {
            InitializeComponent();
            _requestPart = requestPart;
            _action = action;
        }

        private void RequestPartEditForm_Load(object sender, EventArgs e) {
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
                measureBox.SelectedIndex = 0;
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                nameBox.Text = _requestPart.Part.Name;
                typeBox.Text = _requestPart.Part.Type;
                amountBox.Text = _requestPart.Part.Amount.ToString();
                measureBox.SelectedItem = _requestPart.Part.Measure;
                specificationsBox.Text = _requestPart.Part.Description;
                dateTimePicker.Value = _requestPart.Date;
                reasonBox.Text = _requestPart.Reason;
                statusBox.Checked = _requestPart.Status;
            }
            Program.Client.Connection.Send(new Packet4PartList("", false, false, null, null));
            Program.Client.Connection.Send(new Packet8GroupList(null));
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(nameBox.Text)
                || string.IsNullOrEmpty(typeBox.Text)
                || !int.TryParse(amountBox.Text, out int amount) || amount < 1
                || groupBox.SelectedIndex < 0) {
                MessageBox.Show("Введены неверные данные.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_action != CuAction.Create) {
                _requestPart.Part.Name = nameBox.Text;
                _requestPart.Part.Type = typeBox.Text;
                _requestPart.Part.Amount = amount;
                _requestPart.Part.Measure = measureBox.Text;
                _requestPart.Part.Description = specificationsBox.Text;
                _requestPart.Part.Group = (Group) groupBox.SelectedItem;
                _requestPart.Date = dateTimePicker.Value.Date;
                _requestPart.DateCompleted
                    = statusBox.Checked ? DateTime.Now.Date : DateTime.MinValue.Date;
                _requestPart.Reason = reasonBox.Text;
                _requestPart.Status = statusBox.Checked;
            } else {
                DataGridView partGridView = (DataGridView) Application
                    .OpenForms["RequestEditForm"].Controls["partGridView"];
                SortableBindingList<RequestPart> parts
                    = (SortableBindingList<RequestPart>) partGridView.DataSource;
                parts.Add(new RequestPart {
                    Part = new Part {
                        Name = nameBox.Text,
                        Type = typeBox.Text,
                        Amount = amount,
                        Measure = measureBox.Text,
                        Description = specificationsBox.Text,
                        Group = (Group) groupBox.SelectedItem
                    },
                    Date = dateTimePicker.Value.Date,
                    DateCompleted = DateTime.MinValue.Date,
                    Reason = reasonBox.Text,
                    Status = statusBox.Checked
                });
                partGridView.DataSource = parts;
            }
            Close();
        }

        private void partBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (partBox.SelectedIndex > 0) {
                Part part = (Part) partBox.SelectedItem;
                nameBox.Text = part.Name;
                typeBox.Text = part.Type;
                measureBox.SelectedItem = part.Measure;
                specificationsBox.Text = part.Description;
                groupBox.SelectedItem = part.Group;
            }
        }

        private void groupButton_Click(object sender, EventArgs e) {
            new GroupEditForm(null, CuAction.Create).ShowDialog();
        }

        public void SelectGroup() {
            if (_action == CuAction.Create) {
                return;
            }
            groupBox.SelectedItem = _requestPart.Part.Group;
        }
    }
}
