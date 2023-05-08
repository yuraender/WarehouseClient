using System;
using System.Drawing;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.Forms.Admin.Edit;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin {
    public partial class EntityForm : CustomForm {

        private readonly User _user;

        public Entities Type {
            get; private set;
        }

        public EntityForm(string name, Entities type, User user) {
            InitializeComponent();
            Text = name;
            Type = type;
            _user = user;
        }

        private void EntityForm_Load(object sender, EventArgs e) {
            CenterToParent();
            if (Type == Entities.Users) {
                Program.Client.Connection.Send(new Packet2UserList());
            } else if (Type == Entities.Parts) {
                if (!_user.IsAdmin) {
                    Program.Client.Connection.Send(new Packet4PartList("", false, false, null, _user.Unit));
                } else {
                    Program.Client.Connection.Send(new Packet4PartList("", false, false, null, null));
                }
            } else if (Type == Entities.Groups) {
                Program.Client.Connection.Send(new Packet8GroupList(null));
            } else {
                Program.Client.Connection.Send(new Packet10UnitList());
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e) {
            int row = dataGridView.HitTest(e.X, e.Y).RowIndex;
            if (e.Button != MouseButtons.Right) {
                return;
            }
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripItem createItem = menu.Items.Add("Добавить");
            ToolStripItem updateItem = menu.Items.Add("Обновить");
            menu.Items.Add(new ToolStripMenuItem("Действия"));
            LoadMenuStripItems(menu, row);
            ToolStripItem deleteItem = menu.Items.Add("Удалить");
            deleteItem.Click += (s, ev) => Delete(row);
            if (Type == Entities.Parts) {
                Part part = row >= 0 ? (Part) dataGridView.Rows[row].DataBoundItem : null;
                updateItem.Enabled = row >= 0 && (_user.IsAdmin || _user.IsUnitAdmin);
                deleteItem.Enabled = row >= 0 && (_user.IsAdmin || _user.IsUnitAdmin);
            } else {
                updateItem.Enabled = row >= 0 && _user.IsAdmin;
                deleteItem.Enabled = row >= 0 && _user.IsAdmin;
            }
            menu.Show(dataGridView, new Point(e.X, e.Y));
        }

        private void LoadMenuStripItems(ContextMenuStrip menu, int row) {
            ToolStripMenuItem actionsMenuItem = (ToolStripMenuItem) menu.Items[2];
            if (Type == Entities.Users) {
                menu.Items[0].Click += (s, ev) => {
                    new UserEditForm(null, CuAction.Create, true).ShowDialog();
                };
                menu.Items[1].Click += (s, ev) => {
                    User user = (User) dataGridView.Rows[row].DataBoundItem;
                    new UserEditForm(user, CuAction.Update, true).ShowDialog();
                };

                ToolStripItem makePasswordChangeItem
                    = actionsMenuItem.DropDownItems.Add("Сбросить пароль");
                makePasswordChangeItem.Click += (s, ev) => {
                    User user = (User) dataGridView.Rows[row].DataBoundItem;
                    string password = new Random().Next(0, 1000000).ToString("D6");
                    user.Password = password;
                    user.IsPasswordChanged = false;
                    Program.Client.Connection.Send(new Packet3UserEdit(user, CuAction.Update));
                    MessageBox.Show($"Новый пароль пользователя — {password}", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            } else if (Type == Entities.Parts) {
                menu.Items[0].Click += (s, ev) => {
                    new PartEditForm(null, _user.Unit, CuAction.Create).ShowDialog();
                };
                menu.Items[1].Click += (s, ev) => {
                    Part part = (Part) dataGridView.Rows[row].DataBoundItem;
                    new PartEditForm(part, _user.Unit, CuAction.Update).ShowDialog();
                };
            } else if (Type == Entities.Groups) {
                menu.Items[0].Click += (s, ev) => {
                    new GroupEditForm(null, CuAction.Create).ShowDialog();
                };
                menu.Items[1].Click += (s, ev) => {
                    Group group = (Group) dataGridView.Rows[row].DataBoundItem;
                    new GroupEditForm(group, CuAction.Update).ShowDialog();
                };
            } else {
                menu.Items[0].Click += (s, ev) => {
                    new UnitEditForm(null, CuAction.Create).ShowDialog();
                };
                menu.Items[1].Click += (s, ev) => {
                    Unit unit = (Unit) dataGridView.Rows[row].DataBoundItem;
                    new UnitEditForm(unit, CuAction.Update).ShowDialog();
                };
            }

            for (int i = 2; i < menu.Items.Count; i++) {
                menu.Items[i].Enabled = row >= 0;
            }
            if (actionsMenuItem.DropDownItems.Count == 0) {
                actionsMenuItem.Enabled = false;
            }
        }

        private void Delete(int row) {
            DialogResult result = MessageBox.Show(
                "Будут удалены все сущности, ссылающиеся на эту запись."
                + "\nВы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result != DialogResult.OK) {
                return;
            }
            if (Type == Entities.Users) {
                User user = (User) dataGridView.Rows[row].DataBoundItem;
                Program.Client.Connection.Send(new Packet3UserEdit(user, CuAction.Delete));
            } else if (Type == Entities.Parts) {
                Part part = (Part) dataGridView.Rows[row].DataBoundItem;
                Program.Client.Connection.Send(new Packet5PartEdit(part, CuAction.Delete));
            } else if (Type == Entities.Groups) {
                Group group = (Group) dataGridView.Rows[row].DataBoundItem;
                Program.Client.Connection.Send(new Packet9GroupEdit(group, CuAction.Delete));
            } else {
                Unit unit = (Unit) dataGridView.Rows[row].DataBoundItem;
                Program.Client.Connection.Send(new Packet11UnitEdit(unit, CuAction.Delete));
            }
            dataGridView.Rows.RemoveAt(row);
        }
    }
}
