using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QLKTXWindowsForms
{
    internal class ExportExcel
    {
        public static void DataToExcel(DataGridView dataGridView, string text = "excel")
        {
            // Tạo đối tượng Excel và mở một workbook mới
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);

            // Tạo một worksheet và đặt tên cho nó
            Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ExportedFromDataGridView";

            // Thêm tiêu đề cho bảng
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                Console.WriteLine(dataGridView.Columns[i - 1].HeaderText);
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, i], worksheet.Cells[1, i]];
                headerRange.Font.Bold = true;
                headerRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gold);
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                headerRange.RowHeight = 30;
            }
            // Thêm dữ liệu vào bảng
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    Console.WriteLine(dataGridView.Rows[i].Cells[j].Value == null);
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value != null ? dataGridView.Rows[i].Cells[j].Value.ToString() : "";
                }
            }
            Excel.Range columnsRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dataGridView.Rows.Count + 1, dataGridView.Columns.Count]];
            columnsRange.Columns.AutoFit();
            columnsRange.RowHeight = 22;
            // Hiển thị dialog để người dùng chọn nơi lưu file
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.FileName = text;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveDialog.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook, Type.Missing,
                    Type.Missing, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                    Excel.XlSaveConflictResolution.xlUserResolution, true, Type.Missing, Type.Missing, Type.Missing);
            }

            // Đóng workbook và Excel
            workbook.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
        }
    }
}
