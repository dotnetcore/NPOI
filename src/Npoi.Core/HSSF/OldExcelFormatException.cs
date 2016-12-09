using System;

namespace Npoi.Core.HSSF
{
    [Serializable]
    public class OldExcelFormatException : Exception
    {
        public OldExcelFormatException(string s)
            : base(s)
        { }
    }
}