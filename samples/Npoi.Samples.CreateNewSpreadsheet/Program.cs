using System;
using System.IO;
using System.Collections.Generic;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using NPOI.XWPF.UserModel;

namespace Npoi.Samples.CreateNewSpreadsheet
{
    public class Program
    {
        public static void Main(string[] args) {
            //ExportExcel();
            //ExportExcelHSSF();
            //ExportWord();
            //ImportExcelHSSF();
            Issue32.Run();
            Console.Read();
        }

        private static void ImportExcelHSSF() {
            Stream templateStream = new MemoryStream();
            using (var file = new FileStream("D:\\2007.xlsx", FileMode.Open, FileAccess.Read)) {
                file.CopyTo(templateStream);
                templateStream.Seek(0, SeekOrigin.Begin);
            }
            var templateWorkbook = new XSSFWorkbook(templateStream);
            //var sheet = templateWorkbook.GetSheetAt(0);
            ISheet sheet = templateWorkbook.CreateSheet("Test") as XSSFSheet;
            sheet.SetAutoFilter(new CellRangeAddress(0,sheet.LastRowNum,0,2));

            var fileStream = new FileStream("D:\\moban2.xls", FileMode.Create);
            templateWorkbook.Write(fileStream);
            fileStream.Close();
            //Console.WriteLine(templateWorkbook.GetSheetAt(0).PhysicalNumberOfRows);
        }

        class XXX
        {
            public int Cell { get; set; }
            public string Value { get; set; }
        }

        private static void ImportExcel() {

            var newFile = "newbook2.core.xlsx";
            var celldata = new List<XXX>{
                new XXX{ Cell =0,Value="00000"},
                new XXX{ Cell = 1,Value = "1111111"  }
            };

            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write)) {
                //excelPath-模板路径，为传递过来的参数
                IWorkbook wb = new XSSFWorkbook("newbook.core.xlsx");

                ISheet sheet1 = wb.GetSheetAt(0);

                //celldata-需要插入的数据，参数          
                foreach (var x in celldata) {
                    IRow row = sheet1.GetRow(x.Cell);
                    row.GetCell(x.Cell).SetCellValue(x.Value);
                }
                wb.Write(fs);
            }
        }

        private static void ExportExcelHSSF() {
            var newFile = @"newbook.core.xls";

            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write)) {
                IWorkbook workbook = new HSSFWorkbook();
                ISheet sheet1 = workbook.CreateSheet("Sheet1");
                sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 10));
                //ICreationHelper cH = wb.GetCreationHelper();
                var rowIndex = 0;
                IRow row = sheet1.CreateRow(rowIndex);
                row.Height = 30 * 80;
                var cell = row.CreateCell(0);
                var font = workbook.CreateFont();
                font.IsBold = true;
                font.Color = HSSFColor.DarkBlue.Index2;
                cell.CellStyle.SetFont(font);

                cell.SetCellValue("A very long piece of text that I want to auto-fit innit, yeah. Although if it gets really, really long it'll probably start messing up more.");
                sheet1.AutoSizeColumn(0);
                rowIndex++;

                // 新增試算表。
                var sheet2 = workbook.CreateSheet("My Sheet");
                // 建立儲存格樣式。
                var style1 = workbook.CreateCellStyle();
                style1.FillForegroundColor = HSSFColor.Blue.Index2;
                style1.FillPattern = FillPattern.SolidForeground;

                var style2 = workbook.CreateCellStyle();
                style2.FillForegroundColor = HSSFColor.Yellow.Index2;
                style2.FillPattern = FillPattern.SolidForeground;

                // 設定儲存格樣式與資料。
                var cell2 = sheet2.CreateRow(0).CreateCell(0);
                cell2.CellStyle = style1;
                cell2.SetCellValue(0);

                cell2 = sheet2.CreateRow(1).CreateCell(0);
                cell2.CellStyle = style2;
                cell2.SetCellValue(1);

                cell2 = sheet2.CreateRow(2).CreateCell(0);
                cell2.CellStyle = style1;
                cell2.SetCellValue(2);

                cell2 = sheet2.CreateRow(3).CreateCell(0);
                cell2.CellStyle = style2;
                cell2.SetCellValue(3);

                cell2 = sheet2.CreateRow(4).CreateCell(0);
                cell2.CellStyle = style1;
                cell2.SetCellValue(4);

                workbook.Write(fs);
            }
            Console.WriteLine("Excel  Done");
        }
        private static void ExportExcel() {
            var newFile = @"newbook.core.xlsx";

            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write)) {
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet1 = workbook.CreateSheet("Sheet1");
                sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 10));
                //ICreationHelper cH = wb.GetCreationHelper();
                var rowIndex = 0;
                IRow row = sheet1.CreateRow(rowIndex);
                row.Height = 30 * 80;
                var cell = row.CreateCell(0);
                var font = workbook.CreateFont();
                font.IsBold = true;
                font.Color = HSSFColor.DarkBlue.Index2;
                cell.CellStyle.SetFont(font);

                cell.SetCellValue("A very long piece of text that I want to auto-fit innit, yeah. Although if it gets really, really long it'll probably start messing up more.");
                sheet1.AutoSizeColumn(0);
                rowIndex++;

                // 新增試算表。
                var sheet2 = workbook.CreateSheet("My Sheet");
                // 建立儲存格樣式。
                var style1 = workbook.CreateCellStyle();
                style1.FillForegroundColor = HSSFColor.Blue.Index2;
                style1.FillPattern = FillPattern.SolidForeground;

                var style2 = workbook.CreateCellStyle();
                style2.FillForegroundColor = HSSFColor.Yellow.Index2;
                style2.FillPattern = FillPattern.SolidForeground;

                // 設定儲存格樣式與資料。
                var cell2 = sheet2.CreateRow(0).CreateCell(0);
                cell2.CellStyle = style1;
                cell2.SetCellValue(0);

                cell2 = sheet2.CreateRow(1).CreateCell(0);
                cell2.CellStyle = style2;
                cell2.SetCellValue(1);

                cell2 = sheet2.CreateRow(2).CreateCell(0);
                cell2.CellStyle = style1;
                cell2.SetCellValue(2);

                cell2 = sheet2.CreateRow(3).CreateCell(0);
                cell2.CellStyle = style2;
                cell2.SetCellValue(3);

                cell2 = sheet2.CreateRow(4).CreateCell(0);
                cell2.CellStyle = style1;
                cell2.SetCellValue(4);

                workbook.Write(fs);
            }
            Console.WriteLine("Excel  Done");
        }

        private static void ExportWord() {
            var newFile2 = @"newbook.core.docx";
            using (var fs = new FileStream(newFile2, FileMode.Create, FileAccess.Write)) {
                XWPFDocument doc = new XWPFDocument();
                var p0 = doc.CreateParagraph();
                p0.Alignment = ParagraphAlignment.LEFT;
                XWPFRun r0 = p0.CreateRun();
                r0.FontFamily = "宋体";
                r0.FontSize = 18;
                r0.IsBold = true;
                r0.SetText("未登录过学生的账号密码");

                doc.Write(fs);
            }
            Console.WriteLine("Word  Done");
        }
    }
}