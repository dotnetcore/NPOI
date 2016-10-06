using System;
using System.Collections.Generic;
using System.Text;

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
