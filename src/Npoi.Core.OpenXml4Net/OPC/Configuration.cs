using System;

namespace Npoi.Core.OpenXml4Net.OPC
{
    /// <summary>
    ///  Storage class for configuration storage parameters.
    /// </summary>  
    public class Configuration
    {
        // TODO configuration by default. should be clearly stated that it should be
        // changed to match installation path
        // as schemas dir is needed in runtime
        static private string pathForXmlSchema = System.AppContext.BaseDirectory
                + @"\" + "src" + @"\" + "schemas";

        public static String PathForXmlSchema
        {
            get
            {
                return pathForXmlSchema;
            }
            set
            {
                Configuration.pathForXmlSchema = value;
            }
        }
    }
}