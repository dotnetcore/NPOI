using System;
using System.Globalization;
using System.Text;

namespace TestCases
{
	public class StringComparisonShim
	{
		public static StringComparison InvariantCultureIgnoreCase => StringComparison.OrdinalIgnoreCase;
	}
	public class EncodingShim
	{
		public static Encoding Default => Encoding.UTF8;
	}
	public class AppSettingsShim
	{
		public static string GetSetting(string name)
		{
			throw new NotImplementedException();
		}
	}
	public class CultureShim
	{
		public static CultureInfo InstalledUICulture => CultureInfo.CurrentUICulture;

		//TestCases.CultureShim.SetCurrentCulture("en-US")
		public static CultureInfo CreateSpecificCulture(string name)
		{
			throw new NotImplementedException();
		}
		public static CultureInfo SetCurrentCulture(string name)
		{
			throw new NotImplementedException();
		}
		public static CultureInfo GetCultureInfo(string name)
		{
			throw new NotImplementedException();
		}
	}
}