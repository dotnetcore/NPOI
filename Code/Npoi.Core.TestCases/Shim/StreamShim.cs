using System.IO;

namespace System
{
	public static class StreamShim
	{
		public static void Close(this Stream stream)
		{
			stream.Dispose();
		}
	}
}