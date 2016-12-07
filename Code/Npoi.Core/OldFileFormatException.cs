using System;

namespace Npoi.Core
{
    [Serializable]
    public class OldFileFormatException : UnsupportedFileFormatException
    {
        public OldFileFormatException(string s)
            : base(s)
        { }
    }
}