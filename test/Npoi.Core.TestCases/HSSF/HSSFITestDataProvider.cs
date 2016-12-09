using System;
using System.Collections.Generic;
using System.Text;
using TestCases.SS;
using Npoi.Core.HSSF.UserModel;
using Npoi.Core.SS;
using Npoi.Core.SS.UserModel;

namespace TestCases.HSSF
{
    public class HSSFITestDataProvider : ITestDataProvider
    {
        public IWorkbook OpenSampleWorkbook(string sampleFileName)
        {
            return HSSFTestDataSamples.OpenSampleWorkbook(sampleFileName);
        }

        public IWorkbook WriteOutAndReadBack(IWorkbook original)
        {
            if (!(original is HSSFWorkbook))
            {
                throw new ArgumentException("Expected an instance of HSSFWorkbook");
            }

            return HSSFTestDataSamples.WriteOutAndReadBack((HSSFWorkbook)original);
        }

        public IWorkbook CreateWorkbook()
        {
            return new HSSFWorkbook();
        }
        public IFormulaEvaluator CreateFormulaEvaluator(IWorkbook wb)
        {
            return new HSSFFormulaEvaluator((HSSFWorkbook)wb);
        }
        public byte[] GetTestDataFileContent(string fileName)
        {
            return POIDataSamples.GetSpreadSheetInstance().ReadFile(fileName);
        }

        public SpreadsheetVersion GetSpreadsheetVersion()
        {
            return SpreadsheetVersion.EXCEL97;
        }

        public string StandardFileNameExtension
        {
            get { return "xls"; }
        }

        private HSSFITestDataProvider() { }
        private static HSSFITestDataProvider inst = new HSSFITestDataProvider();
        public static HSSFITestDataProvider Instance
        {
            get
            {
                return inst;
            }
        }
    }
}
