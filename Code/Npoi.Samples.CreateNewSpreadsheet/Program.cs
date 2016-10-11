using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Npoi.Core.HSSF.Record.Crypto;
using Npoi.Core.OpenXmlFormats.Spreadsheet;
using Npoi.Core.SS.UserModel;
using Npoi.Core.XSSF.UserModel;

namespace Npoi.Samples.CreateNewSpreadsheet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var newFile = @"D:\temp\excel\newbook.core.xlsx";
            using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write))
            {
                IWorkbook wb = new XSSFWorkbook();
                ISheet sheet = wb.CreateSheet("Sheet1");
                //ICreationHelper cH = wb.GetCreationHelper();
                var rowIndex = 0;
                IRow row = sheet.CreateRow(rowIndex);
                var cell = row.CreateCell(0);
                var font = new XSSFFont();
                font.IsBold = true;
                cell.CellStyle.SetFont(font);
                cell.SetCellValue("A very long piece of text that I want to auto-fit innit, yeah. Although if it gets really, really long it'll probably start messing up more.");
                sheet.AutoSizeColumn(0);
                rowIndex++;
                wb.Write(fs);
            }
            Console.WriteLine("Done");
        }
    }
}
