using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;
using WarehouseClient.Utils;

namespace WarehouseClient.Forms.Requests {
    public partial class RequestEditForm : CustomForm {

        private Request _request;
        private CuAction _action;

        public RequestEditForm(Request request, CuAction action) {
            InitializeComponent();
            _request = request != null
                ? request
                : new Request {
                    User = ((MainForm) Application.OpenForms["MainForm"]).User
                };
            _action = action;
        }

        private void RequestEditForm_Load(object sender, EventArgs e) {
            if (_action == CuAction.Create) {
                Text = "Добавление";
                createUpdateButton.Text = "Добавить";
                requesterBox.Text
                    = ((MainForm) Application.OpenForms["MainForm"]).User.ToString();
                partGridView.DataSource = new SortableBindingList<RequestPart>(new List<RequestPart>());
            } else {
                Text = "Обновление";
                createUpdateButton.Text = "Обновить";
                requesterBox.Text = _request.User.ToString();
                partGridView.DataSource = new SortableBindingList<RequestPart>(_request.Parts);
            }
            partGridView.Columns["Part"].HeaderText = "Деталь";
            partGridView.Columns["Date"].HeaderText = "До";
            partGridView.Columns["DateCompleted"].HeaderText = "Выполнено";
            partGridView.Columns["Reason"].HeaderText = "Обоснование необходимости";
            partGridView.Columns["Status"].HeaderText = "Статус";
            partGridView.AutoResizeColumns();
        }

        private void completeButton_Click(object sender, EventArgs e) {
            if (partGridView.CurrentRow == null) {
                return;
            }
            RequestPart requestPart = (RequestPart) partGridView.CurrentRow.DataBoundItem;
            if (requestPart == null || requestPart.Status) {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите отметить запись выполненной?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result != DialogResult.OK) {
                return;
            }
            requestPart.DateCompleted = DateTime.Now.Date;
            requestPart.Status = true;
            Program.Client.Connection.Send(new Packet16RequestPart(requestPart.Part));
            createUpdateButton_Click(null, null);
            RequestEditForm_Load(null, null);
            ((MainForm) Application.OpenForms["MainForm"]).searchButton_Click(null, null);
        }

        private void createButton_Click(object sender, EventArgs e) {
            new RequestPartEditForm(null, CuAction.Create).ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            if (partGridView.CurrentRow == null) {
                return;
            }
            RequestPart requestPart = (RequestPart) partGridView.CurrentRow.DataBoundItem;
            if (requestPart == null || requestPart.Status) {
                DialogResult result = MessageBox.Show(
                    "Нельзя изменить выполненную запись.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new RequestPartEditForm(requestPart, CuAction.Update).ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (partGridView.CurrentRow == null) {
                return;
            }
            RequestPart requestPart = (RequestPart) partGridView.CurrentRow.DataBoundItem;
            if (requestPart == null || requestPart.Status) {
                DialogResult result = MessageBox.Show(
                    "Нельзя удалить выполненную запись.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            partGridView.Rows.RemoveAt(partGridView.CurrentRow.Index);
        }

        private void createUpdateButton_Click(object sender, EventArgs e) {
            object request;
            List<object> parts = new List<object>();
            foreach (RequestPart rp in (SortableBindingList<RequestPart>) partGridView.DataSource) {
                parts.Add(new {
                    rp.Part.Name, rp.Part.Type, rp.Part.Amount, rp.Part.Measure, rp.Part.Description, rp.Part.Group,
                    rp.Date.Date, rp.DateCompleted, rp.Reason, rp.Status
                });
            }
            if (parts.Count == 0) {
                DialogResult result = MessageBox.Show(
                    "Нельзя создать пустую заявку.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_action != CuAction.Create) {
                request = new {
                    _request.ID,
                    _request.Number,
                    _request.Date,
                    RequestInfo = JsonConvert.SerializeObject(parts),
                    _request.User
                };
            } else {
                request = new {
                    RequestInfo = JsonConvert.SerializeObject(parts),
                    _request.User
                };
            }
            Program.Client.Connection.Send(new Packet15RequestEdit(request, _action));
            if (e != null) {
                Close();
            }
        }

        private void RequestEditForm_FormClosed(object sender, FormClosedEventArgs e) {
            ComboBox yearBox = (ComboBox) ((RequestForm) Application.OpenForms["RequestForm"])
                .Controls["searchBox"].Controls["yearBox"];
            Program.Client.Connection.Send(new Packet14RequestList((int) yearBox.SelectedItem));
        }
    }
}
