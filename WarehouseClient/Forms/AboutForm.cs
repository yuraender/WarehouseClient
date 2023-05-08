using System.Reflection;
using System.Windows.Forms;

namespace WarehouseClient.Forms {
    public partial class AboutForm : CustomForm {
        public AboutForm() {
            InitializeComponent();
            Text = "О программе Склад";
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = string.Format("Версия {0}", AssemblyVersion);
            labelCompanyName.Text = "ПАО \"ГОФРОН\"";
            textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors
        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyDescription {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyDescriptionAttribute) attributes[0]).Description;
            }
        }

        public string AssemblyProduct {
            get {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0) {
                    return "";
                }
                return ((AssemblyProductAttribute) attributes[0]).Product;
            }
        }
        #endregion
    }
}
