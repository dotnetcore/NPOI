<p align="center">
    <span>English</span> |  
    <a href="README.zh-CN.md">中文</a>
</p>

# NPOI

[![NuGet](https://img.shields.io/nuget/v/DotNetCore.NPOI.svg)](https://www.nuget.org/packages/DotNetCore.NPOI)
[![Build status](https://ci.appveyor.com/api/projects/status/k774la3yfxf0yfv8?svg=true)](https://ci.appveyor.com/project/yuleyule66/npoi)

This project is migrated from Tony Qu's [NPOI](https://github.com/tonyqus/npoi) by .NET Core Community.

## Announcement

The root upstream project of the NPOI project is [tonyqus/NPOI](https://github.com/tonyqus/NPOI), which is the .NET version of the [Apache POI](https://github.com/apache/poi). [tonyqus/NPOI](https://github.com/tonyqus/NPOI) is the project with the largest number of downloads of nuget packages in the Chinese-speaking area. Developers at home and abroad know that this kind of glory and contribution cannot be obliterated. Just like Linux has derived so many distributions, but no one can deny Linus's contribution.

[dotnetcore/NPOI](https://github.com/dotnetcore/NPOI), as a downstream project of the [tonyqus/NPOI](https://github.com/tonyqus/NPOI) project, was born at the end of 2016. At that time, developers urgently needed the .NET Core version of NPOI. At that time, after receiving a reply from tonyqus, he **made it clear** that he "has no intention of migrating and maintaining the .NET Core version." So [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) was born. It forks from [tonyqus/NPOI](https://github.com/tonyqus/NPOI) and is known to upstream project authors. The upstream project author has repeatedly asked @alexinea about the progress of the [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) unit test.

The migration method of [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) is that @yang-xiaodong migrates file by file. All readers can understand that the namespace and file directory between the two projects have undergone a lot of changes. In the readme file (README.MD) uploaded for the first time, @yang-xiaodong has stated that this project is the .NET Core version of NPOI, and the NPOI project is still under [tonyqus/NPOI](https://github.com/tonyqus/NPOI).

```
This project is for NPOI Core. NPOI is still under at [https://github.com/tonyqus/npoi](https://github.com/tonyqus/npoi)
```

Mr. Yang has no intention of maintaining the .NET Framework version, and tony qu has no intention of migrating and maintaining the .NET Core version. Therefore, it means that this project is only the .NET Core version of NPOI, and the original version is still in tonyqus.

In subsequent versions, Mr. Yang also made it clear in the readme file that this project was migrated from [tonyqus/NPOI](https://github.com/tonyqus/NPOI).

After @yang-xiaodong learned that @tonyqus clearly did not intend to migrate and maintain [tonyqus/NPOI](https://github.com/tonyqus/NPOI) to .NET Core, with the assistance of GitHub, removed the fork relationship between [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) and [tonyqus/NPOI](https://github.com/tonyqus/NPOI). Since then, the [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) project has become an independent downstream project to exist and develop independently, just like a Linux downstream distribution project.

For open source projects, it is impossible for everyone to be so perfect and rigorous at all times, as long as they do not violate the open source agreement or license. Mr. Yang has no intention and NCC has no intention to obliterate any glory of @tonyqus.

We believe that [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) has completed her historical mission. She gave a choice when the community most needed the .NET Core version of NPOI.

As an upstream project, tony qu has no right to require downstream projects to be archived. Has anyone heard that upstream Linux distributions can require downstream Linux distributions to be archived?

After discussion within the NCC PMC, it was decided not to argue with him, and to block him at the organizational level.

So the storm came, tony qu contacted to persuade NCC member projects to leave NCC, contacted Microsoft to ask for DMCA dotnetcore (because he thought github.com/dotnetcore was too formal) and so on. This series of actions led to controversy in the Natasha WeChat group. But on the contrary, the NCC QQ group and WeChat group did not discuss this matter-because everyone knew that [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) did not violate any open source license.

We condemn the behavior of some people passing screenshots of chats in the Natasha WeChat group to tony qu. The author of Natasha, LanX, said at the beginning: If everyone wants to argue, he can just create a new group and let tonyqu come in and discuss it together. I wonder if the person who secretly took the screenshot told tony qu this sentence?

What's more, the Natasha WeChat group is not an NCC group. It is only a Natasha technology studying group, but it is recognized as an NCC group by tony qu. The speeches in the group are also spread everywhere by tony qu. I don't know if he really doesn't know the difference, or pretends he doesn't know the difference.

We don't intend to spend more time entangled with tony qu. After discussing with the NCC PMC, we now decide to archive [dotnetcore/NPOI](https://github.com/dotnetcore/NPOI) to prevent the NCC community from getting into bigger disputes. If there is no accident, we will not make any response to this matter in the future.

[We NCC](https://github.com/dotnetcore) thank the developers for their support and understanding, and we NCC are willing to work with developers and open source communities, including you, to make more contributions to .NET technology and ecology.

---

## What is NPOI ?

NPOI is the .NET version of POI Java project at http://poi.apache.org/. POI is an open source project which can help you read/write xls, doc, ppt files. It has a wide application.

For example, you can use it to
* generate a Excel report without Microsoft Office suite installed on your server and more efficient than call Microsoft Excel ActiveX at background;
* extract text from Office documents to help you implement full-text indexing feature (most of time this feature is used to create search engines). 
* extract images from Office documents
* generate Excel sheets that contains formulas

## Install NuGet Package

```powershell
Install-Package DotNetCore.NPOI
```

## How can it work on Linux?

On Linux, you need install `libgdiplus`. Since 1.2.0 libdl is also required.

- Ubuntu 16.04 and above:
  - apt-get install libgdiplus libc6-dev
  - cd /usr/lib
  - ln -s libgdiplus.so gdiplus.dll
- Fedora 23 and above:
  - dnf install libgdiplus
  - cd /usr/lib64/
  - ln -s libgdiplus.so.0 gdiplus.dll
- CentOS 7 and above:
  - yum install autoconf automake libtool
  - yum install freetype-devel fontconfig libXft-devel
  - yum install libjpeg-turbo-devel libpng-devel giflib-devel libtiff-devel libexif-devel
  - yum install glib2-devel cairo-devel
  - git clone <https://github.com/mono/libgdiplus>
  - cd libgdiplus
  - ./autogen.sh
  - make
  - make install
  - cd /usr/lib64/
  - ln -s /usr/local/lib/libgdiplus.so gdiplus.dll

- Docker
  - Alpine

    ```
    # base sdk-alpine/aspnetcore-runtime-alpine images

    RUN echo "http://dl-cdn.alpinelinux.org/alpine/edge/testing" >> /etc/apk/repositories
    RUN apk --update add libgdiplus
    ```

  - Debian

    ```
    FROM microsoft/dotnet:2.1-aspnetcore-runtime
    RUN apt-get update && apt-get install -y libgdiplus libc6-dev && ln -s /usr/lib/libgdiplus.so /usr/lib/gdiplus.dll
    ...
    ```

## Getting Started

### Export Excel

```csharp
var newFile = @"newbook.core.xlsx";

using (var fs = new FileStream(newFile, FileMode.Create, FileAccess.Write)) {

    IWorkbook workbook = new XSSFWorkbook();

    ISheet sheet1 = workbook.CreateSheet("Sheet1");

    sheet1.AddMergedRegion(new CellRangeAddress(0, 0, 0, 10));
    var rowIndex = 0;
    IRow row = sheet1.CreateRow(rowIndex);
    row.Height = 30 * 80;
    row.CreateCell(0).SetCellValue("this is content");
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

### Export Word

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
