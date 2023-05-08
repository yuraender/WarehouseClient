using System.Drawing;
using WarehouseClient;

namespace System.Windows.Forms {
    public partial class CustomForm : Form {
        public CustomForm() {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            ApplyFont();
        }

        public void ApplyFont() {
            Program.SetAllControlsFont(Controls);
            ControlAdded += (sender, ev) => {
                Program.SetAllControlsFont(Controls);

                Control c = ev.Control;
                if (!(c is DataGridView)) {
                    return;
                }
                c.SizeChanged += (s, e) => {
                    ((DataGridView) c).AutoResizeRows();
                };
            };
        }
    }
}
