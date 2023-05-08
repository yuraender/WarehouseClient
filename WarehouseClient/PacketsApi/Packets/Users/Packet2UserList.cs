using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms.Admin;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.Utils;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet2UserList : PacketBase {
        public Packet2UserList() : base(2) {
        }
    }

    public class Packet2UserListHandler : PacketHandlerBase {

        private List<User> _users;

        public override void Read(BinaryReader reader) {
            _users = JsonConvert.DeserializeObject<List<User>>(reader.ReadString());
        }

        public override void Handle() {
            Form form = Application.OpenForms.Cast<Form>().Last();
            if (form is EntityForm) {
                form = Application.OpenForms.Cast<Form>()
                    .Where(f => f is EntityForm).Select(f => (EntityForm) f)
                    .Where(f => f.Type == Entities.Users).First();
            }
            DataGridView dataGridView = (DataGridView) form.Controls["dataGridView"];
            form.Invoke(new Action(() => {
                if (form is EntityForm) {
                    dataGridView.Columns.Clear();
                    dataGridView.DataSource = new SortableBindingList<User>(_users);
                    dataGridView.Columns["ID"].Width = 50;
                    dataGridView.Columns["Name"].HeaderText = "ФИО";
                    dataGridView.Columns["Login"].HeaderText = "Логин";
                    dataGridView.Columns["Password"].Visible = false;
                    dataGridView.Columns["IsPasswordChanged"].Visible = false;
                    dataGridView.Columns["IsAdmin"].HeaderText = "Администратор";
                    dataGridView.Columns["IsUnitAdmin"].HeaderText = "Администратор подразделения";
                    dataGridView.Columns["Unit"].HeaderText = "Подразделение";
                }
            }));
        }

        public override object Clone() {
            return new Packet2UserListHandler();
        }
    }
}
