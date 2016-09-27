using System;
using System.Collections.Generic;
using System.Text;

namespace NPOI.Util
{
    internal class AssertFailedException : Exception
    {
        public AssertFailedException(string message)
            : base(message)
        {

        }
    }
}
