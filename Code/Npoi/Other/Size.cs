using System.IO;

namespace System.Drawing
{
	public class Image
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public static Image FromStream(Stream stream)
		{
			throw new NotImplementedException();
		}
	}
	public class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public Point(int width, int height)
		{
			Width = width;
			Height = height;
		}
	}
	public class SizeF
	{
		public float Width { get; set; }
		public float Height { get; set; }

		public SizeF(float width, float height)
		{
			Width = width;
			Height = height;
		}
	}
	public class Size
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public Size()
		{
			Width = 0;
			Height = 0;
		}
		public Size(int width, int height)
		{
			Width = width;
			Height = height;
		}
	}
}