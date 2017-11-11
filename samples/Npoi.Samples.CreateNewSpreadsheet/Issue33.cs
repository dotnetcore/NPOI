using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Npoi.Samples.CreateNewSpreadsheet
{
    class Issue33
    {
        public static void Run()
        {
            var issue33 = new Issue33();
            issue33.WriteExcel();
        }

        public void WriteExcel()
        {
            string outputFileName = $@"D:\GitStorage\Npoi.Core\samples\Npoi.Samples.CreateNewSpreadsheet\template-{DateTime.Now.Ticks.ToString()}.xlsx";
            using (var templateStream =new FileStream(@"D:\GitStorage\Npoi.Core\samples\Npoi.Samples.CreateNewSpreadsheet\template.xlsx", FileMode.Open, FileAccess.Read))
            {
                var excel = new XSSFWorkbook(templateStream);
                var cell = excel.GetSheetAt(0).GetRow(2).GetCell(2);
                cell.SetCellValue("Issue 33");

                using (var outputStream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write))
                {
                    excel.Write(outputStream);
                }
            }
            using (var outputStream = File.OpenRead(outputFileName))
            {
                var excel = new XSSFWorkbook(outputStream);
                var cell = excel.GetSheetAt(0).GetRow(2).GetCell(2);
                Console.WriteLine(cell.ToString()); //here can console Issue 33
            }
        }
    }
}
