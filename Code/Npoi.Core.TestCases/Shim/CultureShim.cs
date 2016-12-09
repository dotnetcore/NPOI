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
            if ("POI.testdata.path" == name) {
                return "";//todo://init test path
            }
			throw new NotImplementedException();
		}
	}
	public class CultureShim
	{
		public static CultureInfo InstalledUICulture => CultureInfo.CurrentUICulture;
        private static CultureInfo _cultureInfo = CultureInfo.CurrentCulture;

        //TestCases.CultureShim.SetCurrentCulture("en-US")
        public static CultureInfo CreateSpecificCulture(string name)
		{
			throw new NotImplementedException();
		}
		public static CultureInfo SetCurrentCulture(string name)
		{
            _cultureInfo = new CultureInfo(name);
            return _cultureInfo;

        }
		public static CultureInfo GetCultureInfo(string name)
		{
            if (string.Equals(_cultureInfo.Name, name)) {
                return _cultureInfo;
            }
            return new CultureInfo(name);
		}
	}
}