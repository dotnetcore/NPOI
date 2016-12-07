using System;

namespace Npoi.Core
{
    [Serializable]
    public class EncryptedDocumentException : InvalidOperationException
    {
        public EncryptedDocumentException(string s)
            : base(s)
        { }
    }
}