using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Packets;
using WarehouseClient.Properties;
using Excel = Microsoft.Office.Interop.Excel;

namespace WarehouseClient.Forms.Requests {
    public partial class RequestForm : CustomForm {
        public RequestForm() {
            InitializeComponent();
        }

        private void RequestForm_Load(object sender, EventArgs e) {
            CenterToParent();
            for (int i = DateTime.Now.Year; i >= 2021; i--) {
                yearBox.Items.Add(i);
            }
            yearBox.SelectedItem = DateTime.Now.Year;
            allCheck_CheckedChanged(null, null);
        }

        private void allCheck_CheckedChanged(object sender, EventArgs e) {
            Program.Client.Connection.Send(new Packet14RequestList((int) yearBox.SelectedItem));
        }

        private void completedCheck_CheckedChanged(object sender, EventArgs e) {
            allCheck_CheckedChanged(null, null);
        }

        private void uncompletedCheck_CheckedChanged(object sender, EventArgs e) {
            allCheck_CheckedChanged(null, null);
        }

        private void excelButton_Click(object sender, EventArgs e) {
            string file, folder;
            folder = !Settings.Default.Folder.Equals("")
                ? Settings.Default.Folder
                : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sender == null) {
                Request request = (Request) dataGridView.CurrentRow.DataBoundItem;
                file = $"{folder}\\Заявка №{request.Number} от {request.Date:dd.MM.yyyy}.xlsx";
            } else {
                file = $"{folder}\\Сводная заявка от {DateTime.Now:dd.MM.yyyy}.xlsx";
            }
            File.WriteAllBytes(file, Resources.request);
            Excel.Application excelApp = new Excel.Application();
            Workbook workbook = excelApp.Workbooks.Open(file);
            Worksheet worksheet = (Worksheet) workbook.Worksheets[1];

            if (sender == null) {
                Request request = (Request) dataGridView.CurrentRow.DataBoundItem;
                worksheet.Cells[1, 1] = $"{worksheet.Cells[1, 1].Value} №{request.Number} от {request.Date:dd.MM.yyyy}";
            }

            int line = 4;
            foreach (DataGridViewRow row in dataGridView.Rows) {
                if (sender == null && row.Index != dataGridView.CurrentRow.Index) {
                    continue;
                }
                Request request = (Request) row.DataBoundItem;
                List<RequestPart> parts = request.Parts;
                if (completedCheck.Checked || uncompletedCheck.Checked) {
                    parts = parts.Where(p => p.Status == completedCheck.Checked).ToList();
                }
                foreach (RequestPart part in parts) {
                    int column = 1;
                    worksheet.Cells[line, column++] = $"{part.Part.Name} {part.Part.Type}";
                    worksheet.Cells[line, column++] = part.Part.Description;
                    worksheet.Cells[line, column++] = part.Reason;
                    worksheet.Cells[line, column++] = part.Part.Group.Unit.Name;
                    worksheet.Cells[line, column++] = "ПАО \"ГОФРОН\"";
                    worksheet.Cells[line, column++] = request.User.Name;
                    worksheet.Cells[line, column++] = part.Part.Measure;
                    worksheet.Cells[line, column++] = part.Part.Amount;
                    worksheet.Cells[line, column++] = $"{part.Date:dd.MM.yyyy}";
                    if (part.Status) {
                        if (sender != null) {
                            worksheet.Cells[line, column]
                                = $"Исполнено {part.DateCompleted:dd.MM.yyyy} (Заявка №{request.Number})";
                        } else {
                            worksheet.Cells[line, column] = $"Исполнено {part.DateCompleted:dd.MM.yyyy}";
                        }
                    }
                    for (int i = 1; i <= 11; i++) {
                        worksheet.Cells[line, i].Borders.LineStyle = XlLineStyle.xlContinuous;
                    }
                    line++;
                }
            }

            DialogResult result = MessageBox.Show(
                "Заявка сохранена в выбранной папке. Распечатать?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) {
                worksheet.PrintOut(
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(worksheet);
            workbook.Close(true, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(workbook);
            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }

        private void excelOneButton_Click(object sender, EventArgs e) {
            if (dataGridView.CurrentRow == null) {
                return;
            }
            excelButton_Click(null, null);
        }

        private void createButton_Click(object sender, EventArgs e) {
            new RequestEditForm(null, CuAction.Create).ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e) {
            if (dataGridView.CurrentRow == null) {
                return;
            }
            Request request = (Request) dataGridView.CurrentRow.DataBoundItem;
            if (request != null) {
                new RequestEditForm(request, CuAction.Update).ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (dataGridView.CurrentRow == null) {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Будут удалены все сущности, ссылающиеся на эту запись."
                + "\nВы действительно хотите удалить запись?", "Подтверждение",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (result != DialogResult.OK) {
                return;
            }
            Request request = (Request) dataGridView.CurrentRow.DataBoundItem;
            if (request != null) {
                Program.Client.Connection.Send(new Packet15RequestEdit(request, CuAction.Delete));
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }
    }
}
