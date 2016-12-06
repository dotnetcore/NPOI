namespace System.Drawing
{
    public class Font : IDisposable
    {
        public Font(string name, int size, object style)
        {
            Name = name;
            Size = size;
            Style = style;
        }

        public Font(string name, float size)
        {
            Name = name;
            Size = size;
        }

        public bool Bold { get; set; }
        public bool Italic { get; set; }
        public float Size { get; set; }
        public string Name { get; set; }
        public object Style { get; set; }
        public Font FontFamily { get; set; }

        public void Dispose()
        {
        }
    }
}