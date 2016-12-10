###  NPOI.Core

This project is the .NET Core version of POI Java project. With NPOI, you can read/write Office 2003/2007 files very easily.

### NPOI Core here, NPOI elsewhere

This project is for NPOI Core. NPOI is still under at [https://github.com/tonyqus/npoi](https://github.com/tonyqus/npoi)

### What is NPOI Core?
NPOI Core is a .NET Core version of the NPOI.

Assembly | Module/Namespace | Summary
---|---|---
Npoi.Core.dll| Npoi.Core.POIFS|OLE2/ActiveX文档属性读写库
Npoi.Core.dll|Npoi.Core.DDF| Microsoft Office Drawing读写库
Npoi.Core.dll|Npoi.Core.HPSF| OLE2/ActiveX文档读写库
Npoi.Core.dll|Npoi.Core.HSSF| Microsoft Excel BIFF(Excel 97-2003)格式读写库
Npoi.Core.dll|Npoi.Core.SS|Excel公用接口及Excel公式计算引擎
Npoi.Core.dll|Npoi.Core.Util|基础类库，提供了很多实用功能，可用于其他读写文件格式项目的开发
Npoi.Core.OOXML.dll|Npoi.Core.XSSF|Excel 2007(xlsx)格式读写库
Npoi.Core.OOXML.dll|Npoi.Core.XWPF|Word 2007(docx)格式读写库
Npoi.Core.OpenXml4Net.dll|Npoi.Core.OpenXml4Net|OpenXml底层zip包读写库
Npoi.Core.OpenXmlFormats.dll|Npoi.Core.OpenXmlFormats|微软Office OpenXml对象关系库

### Getting Started


#### Export Excel

```csharp

var newFile = @"newbook.core.xlsx";

using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write)) {

    IWorkbook workbook = new XSSFWorkbook();

    ISheet sheet1 = workbook.CreateSheet("Sheet1");

    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 10));
    var rowIndex = 0;
    IRow row = sheet1.CreateRow(rowIndex);
    row.Height = 30 * 80;
    row.CreateCell(0).SetCellValue("this is content, very long content, very long content, very long content, very long content");
    sheet1.AutoSizeColumn(0);
    rowIndex++;


    var sheet2 = workbook.CreateSheet("Sheet2");
    var style1 = workbook.CreateCellStyle();
    style1.FillForegroundColor = HSSFColor.Blue.Index2;
    style1.FillPattern = FillPattern.SolidForeground;

    var style2 = workbook.CreateCellStyle();
    style2.FillForegroundColor = HSSFColor.Yellow.Index2;
    style2.FillPattern = FillPattern.SolidForeground;

    var cell2 = sheet2.CreateRow(0).CreateCell(0);
    cell2.CellStyle = style1;
    cell2.SetCellValue(0);

    cell2 = sheet2.CreateRow(1).CreateCell(0);
    cell2.CellStyle = style2;
    cell2.SetCellValue(1);

    workbook.Write(fs);
}

```

#### Export Word

```csharp
var newFile2 = @"newbook.core.docx";
using (var fs = new FileStream(newFile2, FileMode.Create, FileAccess.Write)) {
    XWPFDocument doc = new XWPFDocument();
    var p0 = doc.CreateParagraph();
    p0.Alignment = ParagraphAlignment.CENTER;
    XWPFRun r0 = p0.CreateRun();
    r0.FontFamily = "microsoft yahei";
    r0.FontSize = 18;
    r0.IsBold = true;
    r0.SetText("This is title");

    var p1 = doc.CreateParagraph();
    p1.Alignment = ParagraphAlignment.LEFT;
    p1.IndentationFirstLine = 500;
    XWPFRun r1 = p1.CreateRun();
    r1.FontFamily = "·ÂËÎ";
    r1.FontSize = 12;
    r1.IsBold = true;
    r1.SetText("This is content, content content content content content content content content content");

    doc.Write(fs);
}

```
