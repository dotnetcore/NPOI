using System.Runtime.InteropServices;

namespace Npoi.Core.HSSF
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct FrtHeader
    {
        public ushort rt;
        public ushort grbitFrt;
        public long reserved;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct FrtHeaderOld
    {
        public ushort rt;
        public ushort grbitFrt;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct FrtRefHeader
    {
        public ushort rt;
        public ushort grbitFrt;
        public Ref8 ref8;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct Ref8
    {
        public ushort rwFirst;
        public ushort rwLast;
        public ushort colFirst;
        public ushort colLast;
    }

    #region xmlToken

    [StructLayout(LayoutKind.Sequential)]
    internal struct XmlTkHeader
    {
        public sbyte drType;
        public byte unused;
        public ushort xmlTkTag;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct XmlTkBlob
    {
        /// <summary>
        /// The xtHeader.drType field MUST be equal to 0x07.
        /// </summary>
        public XmlTkHeader xtHeader;

        public uint cbBlob;
        public byte[] rgbBlob;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct XmlTkBool
    {
        /// <summary>
        /// The xtHeader.drType field MUST be equal to 0x02.
        /// </summary>
        public XmlTkHeader xtHeader;

        public byte dValue;
        public byte unused;
    }

    internal struct XmlTkDouble
    {
        /// <summary>
        /// The xtHeader.drType field MUST be equal to 0x03.
        /// </summary>
        public XmlTkHeader xtHeader;

        public int unused;
        public double dValue;
    }

    internal struct XmlTkDWord
    {
        /// <summary>
        /// The xtHeader.drType field MUST be equal to 0x04.
        /// </summary>
        public XmlTkHeader xtHeader;

        public int dValue;
    }

    internal struct XmlTkEnd
    {
        /// <summary>
        /// The xtHeader.drType field MUST be equal to 0x01.
        /// </summary>
        public XmlTkHeader xtHeader;
    }

    internal struct XmlTkString
    {
        /// <summary>
        /// The xtHeader.drType field MUST be equal to 0x05.
        /// </summary>
        public XmlTkHeader xtHeader;

        public uint cchValue;

        /// <summary>
        /// An array of Unicode characters. The size of the array, in characters, is specified
        /// by the cchValue field. The size of the field, in bytes, MUST equal the result of
        /// the following formula:cchValue * 2.
        /// </summary>
        public char[] rgbValue;
    }

    internal struct XmlTkStyle
    {
        /// <summary>
        /// The chartStyle.xtHeader.xmlTkTag MUST be equal to 0x0003.
        /// </summary>
        public XmlTkDWord chartStyle;
    }

    internal struct XmlTkToken
    {
        public XmlTkHeader xtHeader;
        public ushort dValue;
    }

    internal struct XmlTkTickMarkSkipFrt
    {
        /// <summary>
        /// The nInterval.xtHeader.xmlTkTag field MUST be equal to 0x0052.
        /// </summary>
        public XmlTkDWord nInterval;
    }

    #endregion xmlToken
}