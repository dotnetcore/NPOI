using System;

namespace Npoi.Core.OpenXml4Net
{
    public class OpenXml4NetException : Exception
    {
        public OpenXml4NetException(string msg)
            : base(msg)
        {
        }

        public OpenXml4NetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}