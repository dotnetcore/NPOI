<p align="center">
    <a href="README.md">English</a> |   
    <span>中文</span>
</p>

# NPOI

[![NuGet](https://img.shields.io/nuget/v/DotNetCore.NPOI.svg)](https://www.nuget.org/packages/DotNetCore.NPOI)
[![Build status](https://ci.appveyor.com/api/projects/status/k774la3yfxf0yfv8?svg=true)](https://ci.appveyor.com/project/yuleyule66/npoi)

本项目由 .NET Core Community 迁移自上游项目 Tony Qu 的 [NPOI](https://github.com/tonyqus/npoi) 。

## 通告

NPOI 项目的最上游项目是 [tonyqus/NPOI](https://github.com/tonyqus/NPOI)，该项目是 [Apache POI](https://github.com/apache/poi) 项目的 .NET 版本。[tonyqus/NPOI](https://github.com/tonyqus/NPOI) 是华语地区 [NUGET](https://www.nuget.org/packages/NPOI/) 包下载量最大的项目，为全体海内外开发者们所知，这种荣耀与贡献是谁也不可能抹杀的，就像 Linux 衍生出那么多版本，但又有谁会否认 Linus Torvalds 的贡献？

dotnetcore/NPOI 作为 tonyqus/NPOI 项目的下游项目，在 2016 年至 2017 年社区急需 .NET Core 版本的 NPOI，且**明确**收到 tony qu 无意迁移和维护 .NET Core 版本的情况下诞生，它是 tonyqus/NPOI 的迁移版本。tony qu 亦多次通过 @alexinea 询问 dotnetcore/NPOI 单元测试的进度。dotnetcore/NPOI 的迁移方式是杨晓东老师（我们对他的尊称，而不是他自称）一个文件一个文件地迁移的，两个项目的命名空间和文件目录都有不少变化。在第一次上传的自述文件（README.MD）中，杨晓东老师说明了此项目是 NPOI 的 Core 版本，NPOI 项目依然在 tonyqus/NPOI 下。

```
This project is for NPOI Core. NPOI is still under at [https://github.com/tonyqus/npoi](https://github.com/tonyqus/npoi)
```

杨晓东老师无意维护 NFX 版本，而 tony qu 亦无意做 .NET Core 版本的迁移和维护，因此说明这只是 NPOI 的 Core 版本，原版本还是在 tonyqus/NPOI 并无不妥。在后续的版本中，杨晓东老师在自述文件中也明确了这个版本是迁移自 tonyqus/NPOI。因 **明确** 得知 tony qu 无意迁移和维护 .NET Core 版本，在 GitHub 的协助下，移除了 dotnetcore/NPOI 对 tonyqus/NPOI 的 fork 关系，作为独立下游项目单独存在与发展，如同 Linux 下游分发项目。做开源的，每个人、每个时间段、每个场景都不可能做到那么完善和严谨，只要没有违反开源协议即无过错。杨晓东老师无意、NCC 无意抹杀 tony qu 的任何功劳。

我们认为，dotnetcore/NPOI 完成了她的历史使命，在社区最需要 .NET Core 版本 NPOI 的时候给出了一份选择。作为上游项目，tony qu 本无权力要求下游项目归档，可有人听过上游 Linux 可以要求下游的 Linux 归档的？他在发给 @alexinea 和杨晓东老师的邮件中指出 NCC「没有必要靠 NPOI 来撑台面」。经 NCC 内部讨论一致决定：不与其争论，并屏蔽了他。于是暴风雨来了，tony qu 联系劝说 NCC 成员项目离开 NCC 、联系微软要 DMCA dotnetcore（因为他觉得 github.com/dotnetcore 太正式）等，进而导致了一系列 QQ、微信群里的争论。但 NCC QQ 大群和微信群，反而没怎么讨论此事——因为大家都很明白，dotnetcore/NPOI 并未违反任何开源协议。

对于某些人在微信群、QQ 群截取图片传递给 tony qu 的做法，我们实在不敢恭维。Natasha 作者一开始就说过**要争论他可以直接拉群让 tonyqu 来讨论**，不知道传话人可有把这句话带到给 tony qu 呢？更何况 Natasha 群也不是 NCC 的群，它只是 Natasha 技术学习群，却被 tony qu 认定为 NCC 的群，群内的发言也被 tony qu 到处散播，不知道是不知道还是真的不知道。

我们无意花更多的时间与 tony qu 纠缠，经 NCC PMC 讨论，现决定将 dotnetcore/NPOI 存档，以避免 NCC 社区陷入更大的纠纷。如无意外，今后我们也不会再针对这件事做出任何回应。我们感谢海内外开发者们的支持和理解，愿与包括各位在内的广大开发者和开源社区一道，为 .NET 技术和生态做出更多贡献。

## 安装 NuGet 包

```powershell
Install-Package DotNetCore.NPOI
```

## 如何在 Linux 上使用？

在 Linux 上，你需要安装 `libgdiplus`。从 1.2.0 开始，还需要 libdl。

- Ubuntu 16.04 及以上：
  - apt-get install libgdiplus libc6-dev
  - cd /usr/lib
  - ln -s libgdiplus.so gdiplus.dll
- Fedora 23 及以上：
  - dnf install libgdiplus
  - cd /usr/lib64/
  - ln -s libgdiplus.so.0 gdiplus.dll
- CentOS 7 及以上：
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

## 开始

### 导出 Excel

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

### 导出 Word

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
