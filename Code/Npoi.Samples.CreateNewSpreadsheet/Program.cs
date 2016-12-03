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

namespace Npoi.Samples.CreateNewSpreadsheet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var newFile = @"newbook.core.xlsx";
            //using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write))
            //{
            //    IWorkbook wb = new XSSFWorkbook();
            //    ISheet sheet = wb.CreateSheet("Sheet1");
            //    //ICreationHelper cH = wb.GetCreationHelper();
            //    var rowIndex = 0;
            //    IRow row = sheet.CreateRow(rowIndex);
            //    var cell = row.CreateCell(0);
            //    var font = new XSSFFont();
            //    font.IsBold = true;
            //    cell.CellStyle.SetFont(font);
            //    cell.SetCellValue("A very long piece of text that I want to auto-fit innit, yeah. Although if it gets really, really long it'll probably start messing up more.");
            //    sheet.AutoSizeColumn(0);
            //    rowIndex++;
            //    wb.Write(fs);
            //}
            //Console.WriteLine("Excel  Done");
            
            using (FileStream out1 = new FileStream("newbook.core.docx", FileMode.Create, FileAccess.Write)) {

                //创建document对象  
                XWPFDocument doc = new XWPFDocument();
                ////创建段落对象  
                XWPFParagraph p1 = doc.CreateParagraph();
                ////段落对其方式为居中  
                p1.Alignment = ParagraphAlignment.CENTER;
                XWPFRun r1 = p1.CreateRun();//段落中添加文字  
                r1.FontSize = 22;//设置大小  
                r1.FontFamily = "宋体"; //设置字体  
                r1.SetText("段落一");


                XWPFParagraph p2 = doc.CreateParagraph();
                //段落对其方式为居中  
                p2.Alignment = ParagraphAlignment.RIGHT;
                XWPFRun r2 = p2.CreateRun();//向该段落中添加文字  
                r2.FontSize = 15;//设置大小  
                r2.FontFamily = "宋体"; //设置字体  
                r2.SetText("段落二");

                doc.Write(out1);
            }
            Console.WriteLine("Word  Done");
        }
    }
}
