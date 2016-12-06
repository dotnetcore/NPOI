using Npoi.Core.Util;
using System;
using System.Text;

namespace Npoi.Core.HSSF.Record
{
    //Don't remove this class

    /// <summary>
    ///
    /// </summary>
    public class SheetExtRecord : StandardRecord
    {
        private short rt = 0;
        private short grbitFrt = 0;
        private int cb = 0;
        private BitField icvPlain = BitFieldFactory.GetInstance(0x7F);
        private short optionflag = 0xFF;
        private short optionflag2 = 0;
        private BitField icvPlain12 = BitFieldFactory.GetInstance(0x7F);
        private BitField fCondFmtCalc = BitFieldFactory.GetInstance(0x80);
        private BitField fNotPublished = BitFieldFactory.GetInstance(0x100);
        private int xclrType = 0;
        private int xclrValue = 0;
        private long numTint = 0;

        public SheetExtRecord()
        {
            rt = 0x0862;
            IsAutoColor = true;
        }

        public SheetExtRecord(RecordInputStream in1)
        {
            rt = in1.ReadShort();
            if (rt != 0x0862)
            {
                throw new ArgumentException("frtHeader.rt must be equals 0x0862 in SheetExt record");
            }
            grbitFrt = in1.ReadShort();
            in1.ReadInt();  //reserved
            in1.ReadInt();  //reserved
            cb = in1.ReadInt();
            optionflag = in1.ReadShort();
            in1.ReadShort(); //reserved
            if (cb == 0x28)
            {
                optionflag2 = in1.ReadShort();
                xclrType = in1.ReadInt();
                xclrValue = in1.ReadInt();
                numTint = in1.ReadLong();
                in1.ReadShort();
            }
        }

        public short TabColorIndex
        {
            get
            {
                return icvPlain.GetShortValue(optionflag);
            }
            set
            {
                optionflag = icvPlain.SetShortValue(optionflag, value);
            }
        }

        public bool IsAutoColor
        {
            get
            {
                return TabColorIndex == 0x7F;
            }
            set
            {
                if (value)
                    TabColorIndex = 0x7F;
                else
                    TabColorIndex = 0x08;
            }
        }

        public bool EvaluateConditionalFormatting
        {
            get { return fCondFmtCalc.IsSet(optionflag2); }
            set { optionflag2 = (short)fCondFmtCalc.SetBoolean(optionflag2, value); }
        }

        public bool IsSheetPublished
        {
            get { return !fNotPublished.IsSet(optionflag2); }
            set { optionflag2 = (short)fNotPublished.SetBoolean(optionflag2, !value); }
        }

        protected override int DataSize
        {
            get
            {
                return 12 + 4 + 4 + (cb == 0x28 ? 20 : 0);
            }
        }

        public const short sid = 0x862; //2146

        public override short Sid
        {
            get { return sid; }
        }

        public override void Serialize(ILittleEndianOutput out1)
        {
            out1.WriteShort(rt);
            out1.WriteShort(grbitFrt);
            out1.WriteInt(0);
            out1.WriteInt(0);
            cb = this.DataSize;
            out1.WriteInt(cb);
            out1.WriteShort(optionflag);
            out1.WriteShort(0);
            if (cb == 0x28)
            {
                out1.WriteShort(optionflag2);
                out1.WriteInt(xclrType);
                out1.WriteInt(xclrValue);
                out1.WriteLong(numTint);
                out1.WriteShort(0);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[SHEETEXT]");
            sb.Append("[/SHEETEXT]");
            return sb.ToString();
        }

        public override object Clone()
        {
            SheetExtRecord rec = new SheetExtRecord();
            rec.rt = rt;
            rec.grbitFrt = grbitFrt;
            rec.cb = this.DataSize;
            rec.optionflag = optionflag;
            if (cb == 0x28)
            {
                rec.optionflag2 = optionflag2;
                rec.xclrType = xclrType;
                rec.xclrValue = xclrValue;
                rec.numTint = numTint;
            }
            return rec;
        }
    }
}