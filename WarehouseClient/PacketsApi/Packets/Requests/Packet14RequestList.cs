using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms.Requests;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Utils;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet14RequestList : PacketBase {

        private readonly int _year;

        public Packet14RequestList(int year) : base(14) {
            _year = year;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(_year);
        }
    }

    public class Packet14RequestListHandler : PacketHandlerBase {

        private List<Request> _requests = new List<Request>();

        public override void Read(BinaryReader reader) {
            JArray requests = JsonConvert.DeserializeObject<JArray>(reader.ReadString());
            foreach (JObject request in requests) {
                JArray requestParts = JsonConvert
                    .DeserializeObject<JArray>(request.Value<string>("RequestInfo"));
                List<RequestPart> parts = new List<RequestPart>();
                foreach (JObject requestPart in requestParts) {
                    parts.Add(new RequestPart {
                        Part = new Part {
                            Name = requestPart.Value<string>("Name"),
                            Type = requestPart.Value<string>("Type"),
                            Amount = requestPart.Value<int>("Amount"),
                            Measure = requestPart.Value<string>("Measure"),
                            Description = requestPart.Value<string>("Description"),
                            Group = requestPart.GetValue("Group").ToObject<Group>()
                        },
                        Date = requestPart.Value<DateTime>("Date"),
                        DateCompleted = requestPart.Value<DateTime>("DateCompleted"),
                        Reason = requestPart.Value<string>("Reason"),
                        Status = requestPart.Value<bool>("Status")
                    });
                }
                _requests.Add(new Request {
                    ID = request.Value<int>("ID"),
                    Number = request.Value<int>("Number"),
                    Date = request.Value<DateTime>("Date"),
                    Parts = parts,
                    User = request.GetValue("User").ToObject<User>()
                });
            }
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            DataGridView dataGridView = (DataGridView) form.Controls["dataGridView"];
            RadioButton completedCheck = (RadioButton) form.Controls["searchBox"].Controls["completedCheck"];
            RadioButton uncompletedCheck = (RadioButton) form.Controls["searchBox"].Controls["uncompletedCheck"];
            form.Invoke(new Action(() => {
                if (form is RequestForm) {
                    dataGridView.Columns.Clear();
                    if (completedCheck.Checked || uncompletedCheck.Checked) {
                        _requests = _requests.Where(r =>
                            r.Parts.Any(p => p.Status == completedCheck.Checked)
                        ).ToList();
                    }
                    dataGridView.DataSource = new SortableBindingList<Request>(_requests);
                    dataGridView.Columns["ID"].Visible = false;
                    dataGridView.Columns["Number"].HeaderText = "Номер";
                    dataGridView.Columns["Date"].HeaderText = "Дата";
                    dataGridView.Columns.Insert(3, new DataGridViewTextBoxColumn());
                    dataGridView.Columns[3].HeaderText = "Информация";
                    foreach (DataGridViewRow row in dataGridView.Rows) {
                        StringBuilder sb = new StringBuilder();
                        List<RequestPart> parts = _requests[row.Index].Parts;
                        if (completedCheck.Checked || uncompletedCheck.Checked) {
                            parts = parts.Where(p => p.Status == completedCheck.Checked).ToList();
                        }
                        for (int i = 0; i < parts.Count; i++) {
                            sb.Append(parts[i].ToString());
                            if (i + 1 < parts.Count) {
                                sb.Append(Environment.NewLine);
                            }
                        }
                        row.Cells[3].Value = sb.ToString();
                    }
                    dataGridView.Columns["User"].HeaderText = "Запрашивающий";
                    dataGridView.AutoResizeColumns();
                    dataGridView.AutoResizeRows();
                }
            }));
        }

        public override object Clone() {
            return new Packet14RequestListHandler();
        }
    }
}
