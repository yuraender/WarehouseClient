using System;
using System.Linq;
using System.Windows.Forms;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Forms.Admin {
    public partial class LogForm : CustomForm {
        public LogForm() {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e) {
            CenterToParent();
            packetBox.Items.Add("(не выбрано)");
            packetBox.Items.AddRange(Program.Client.Handlers.GetHandlers()
                .Select(h => h.GetType().Name.Replace("Handler", ""))
                .ToArray());
            packetBox.SelectedIndex = 0;
            packetBox_SelectedIndexChanged(null, null);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e) {
            packetBox_SelectedIndexChanged(null, null);
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e) {
            packetBox_SelectedIndexChanged(null, null);
        }

        private void packetBox_SelectedIndexChanged(object sender, EventArgs e) {
            Program.Client.Connection.Send(new Packet12Log(fromDatePicker.Value, toDatePicker.Value));
        }
    }
}
