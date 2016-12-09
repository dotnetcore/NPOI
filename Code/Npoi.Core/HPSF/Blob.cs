using Npoi.Core.Util;

namespace Npoi.Core.HPSF
{
    internal class Blob
    {
        private byte[] _value;

        public Blob(byte[] data, int offset) {
            int size = LittleEndian.GetInt(data, offset);

            if (size == 0) {
                _value = new byte[0];
                return;
            }

            _value = LittleEndian.GetByteArray(data, offset
                    + LittleEndianConsts.INT_SIZE, size);
        }

        public int Size {
            get { return LittleEndianConsts.INT_SIZE + _value.Length; }
        }
    }
}