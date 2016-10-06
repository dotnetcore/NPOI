using System;
using Npoi.Core.OpenXml4Net.Exceptions;

namespace Npoi.Core.OpenXml4Net
{
    public class OpenXml4NetException : Exception
    {
        private Exceptions.InvalidFormatException ex;


        public OpenXml4NetException(String msg)
            : base(msg)
        {

        }

        public OpenXml4NetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
