using System;

namespace Npoi.Core.Util
{
    internal class AssertFailedException : Exception
    {
        public AssertFailedException(string message)
            : base(message)
        {
        }
    }
}