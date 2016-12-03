using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Npoi.Core.HSSF.Record.Crypto;
using Npoi.Core.OpenXmlFormats.Spreadsheet;
using Npoi.Core.SS.UserModel;
using Npoi.Core.XSSF.UserModel;
using Npoi.Core.XWPF.UserModel;
using Npoi.Core.SS.Util;
using Npoi.Core.HSSF.Util;

namespace Npoi.Samples.CreateNewSpreadsheet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExportWord();
        }

        private static void ExportExcel()
        {
            var newFile = @"newbook.core.xlsx";

            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write))
            {

                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet1 = workbook.CreateSheet("Sheet1");
                sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 10));
                //ICreationHelper cH = wb.GetCreationHelper();
                var rowIndex = 0;
                IRow row = sheet1.CreateRow(rowIndex);
                row.Height = 30 * 80;
                var cell = row.CreateCell(0);
                //var font = new XSSFFont();
                var font = workbook.CreateFont();
                font.IsBold = true;
                font.Color = HSSFColor.DarkBlue.Index2;
                font.FontName = "宋体";
                font.FontHeightInPoints = 10;
                cell.CellStyle.SetFont(font);

                cell.SetCellValue("你们什么时候A very long piece of text that I want to auto-fit innit, yeah. Although if it gets really, really long it'll probably start messing up more.");
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

        private static void ExportWord()
        {
            var newFile2 = @"newbook.core.docx";
            using (var fs = new FileStream(newFile2, FileMode.Create, FileAccess.Write))
            {
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
