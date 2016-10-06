using System;

namespace Npoi.Core
{
    [Serializable]
    public class OldFileFormatException : UnsupportedFileFormatException
    {
        public OldFileFormatException(String s)
            : base(s)
        { }

    }
}
