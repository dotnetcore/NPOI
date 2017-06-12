cd ../src/Npoi.Core
nuget pack NPOI.Core.nuspec -OutputDirectory ../../packed
cd ..
cd ../src/Npoi.Core.OpenXml4Net
nuget pack Npoi.Core.OpenXml4Net.nuspec -OutputDirectory ../../packed
cd ..
cd ../src/Npoi.Core.OpenXmlFormats
nuget pack Npoi.Core.OpenXmlFormats.nuspec -OutputDirectory ../../packed
cd ..
cd ../src/Npoi.Core.Ooxml
nuget pack NPOI.Core.Ooxml.nuspec -OutputDirectory ../../packed