using System;

namespace Npoi.Core.OpenXml4Net.Exceptions
{
    public class InvalidFormatException : OpenXml4NetException
    {
        public InvalidFormatException(string message) : base(message)
        {
        }

        public InvalidFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}