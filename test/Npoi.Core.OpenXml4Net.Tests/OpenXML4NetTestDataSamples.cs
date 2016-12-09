using Npoi.Core.Util;
using System;
using System.IO;

namespace Npoi.Core.OpenXml4Net.Tests
{
    public class OpenXml4NetTestDataSamples
    {
        private static POIDataSamples _samples = POIDataSamples.GetOpenXml4NetInstance();

        private OpenXml4NetTestDataSamples() {
            // no instances of this class
        }

        public static Stream OpenSampleStream(string sampleFileName) {
            return _samples.OpenResourceAsStream(sampleFileName);
        }

        public static string GetSampleFileName(string sampleFileName) {
            return new FileInfo(_samples.ResolvedDataDir + sampleFileName).FullName;
        }

        public static FileInfo GetSampleFile(string sampleFileName) {
            return new FileInfo(_samples.ResolvedDataDir + sampleFileName);
        }

        public static FileInfo GetOutputFile(string outputFileName) {
            int dotPos = outputFileName.LastIndexOf('.');
            string suffix = outputFileName.Substring(dotPos);
            string path = TempFile.GetTempFilePath(outputFileName.Substring(0, dotPos), suffix);
            FileStream fs = File.Create(path);
            fs.Dispose();
            return new FileInfo(path);
        }

        public static Stream OpenComplianceSampleStream(string sampleFileName) {
            return _samples.OpenResourceAsStream(sampleFileName);
        }
    }
}