
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Npoi.Samples.CreateNewSpreadsheet
{
    public class Issue32
    {
        public static void Run()
        {
            new Issue32().ReadExcel();
        }

        public void ReadExcel()
        {
            //using (var file = new FileStream(@"D:\GitStorage\Npoi.Core\samples\Npoi.Samples.CreateNewSpreadsheet\template.xlsx", FileMode.Open, FileAccess.Read))
            //{
            //    var excel = new XSSFWorkbook(file);
            //    var cell = excel.GetSheetAt(0).GetRow(0).GetCell(0);
            //    Console.WriteLine(cell.NumericCellValue);
            //}

            //using (var file = new FileStream(@"D:\GitStorage\Npoi.Core\samples\Npoi.Samples.CreateNewSpreadsheet\template.xls", FileMode.Open, FileAccess.Read))
            //{
            //    var excel = new HSSFWorkbook(file);
            //    var cell = excel.GetSheetAt(0).GetRow(1).GetCell(2);
            //    Console.WriteLine(cell.NumericCellValue);
            //}

            string filePath = $@"D:\GitStorage\Npoi.Core\samples\Npoi.Samples.CreateNewSpreadsheet\template.xlsx";
            IWorkbook workbook = WorkbookFactory.Create(filePath);            
            workbook.Close();
        }
    }
}
