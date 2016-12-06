namespace System.Drawing
{
    public class Color
    {
        public static Color White = new Color(255, 255, 255);
        public static Color Black = new Color(255, 255, 255);
        public static Color Red = new Color(255, 255, 255);
        public static Color Green = new Color(255, 255, 255);
        public static Color Blue = new Color(255, 255, 255);
        public static Color Yellow = new Color(255, 255, 255);
        public static Color Wheat = new Color(255, 255, 255);
        public static Color Cyan = new Color(255, 255, 255);
        public static Color Magenta = new Color(255, 255, 255);
        public static Color Orange = new Color(255, 255, 255);
        public static Color Empty = new Color(0, 0, 0);

        public static Color FromArgb(int r, int g, int b)
        {
            return new Color((byte)r, (byte)g, (byte)b);
        }

        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public int ToArgb()
        {
            return 0;
        }
    }
}