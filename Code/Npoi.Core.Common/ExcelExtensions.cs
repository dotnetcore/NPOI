using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace Npoi.Core
{
	public static class ExcelExtensions
	{
		public static XElement CreateElement(this XDocument element, string name)
		{
			return new XElement(name);
		}

		public static string GetAttribute(this XElement element, string name, string sub = null)
		{
			return element.Attribute(name)?.Value ?? sub;
		}

		public static void AppendChild(this XElement element, object content)
		{
			element.Add(content);
		}

		public static void AppendChild(this XDocument element, object content)
		{
			element.Add(content);
		}

		public static XElement CloneNode(this XElement element, bool deep)
		{
			return element;
		}

		public static XAttribute GetAttributeNode(this XElement root, string name)
		{
			throw new NotImplementedException();
		}

		public static ConstructorInfo FilterConstructorsByType(this IEnumerable<ConstructorInfo> constructors, params Type[] types)
		{
			throw new NotImplementedException();
		}

		// This function is duplicated in COMDateTime.cpp 
		// Number of 100ns ticks per time unit 
		private const long TicksPerMillisecond = 10000;
		private const long TicksPerSecond = TicksPerMillisecond * 1000;
		private const long TicksPerMinute = TicksPerSecond * 60;
		private const long TicksPerHour = TicksPerMinute * 60;
		private const long TicksPerDay = TicksPerHour * 24;
		
		// Number of milliseconds per time unit 
		private const int MillisPerSecond = 1000;
		private const int MillisPerMinute = MillisPerSecond * 60;
		private const int MillisPerHour = MillisPerMinute * 60;
		private const int MillisPerDay = MillisPerHour * 24;
		
		// Number of days in a non-leap year 
		private const int DaysPerYear = 365;
		// Number of days in 4 years 
		private const int DaysPer4Years = DaysPerYear * 4 + 1;
		// Number of days in 100 years
		private const int DaysPer100Years = DaysPer4Years * 25 - 1;
		// Number of days in 400 years
		private const int DaysPer400Years = DaysPer100Years * 4 + 1;
		private const int DaysTo1899 = DaysPer400Years*4 + DaysPer100Years*3 - 367;
		private const long DoubleDateOffset = DaysTo1899 * TicksPerDay;



		private const long OADateMinAsTicks = (DaysPer100Years - DaysPerYear) * TicksPerDay;

		private static double TicksToOADate(long value)
		{
			if (value == 0)
				return 0.0;  // Returns OleAut's zero'ed date value.
			if (value < TicksPerDay) // This is a fix for VB. They want the default day to be 1/1/0001 rathar then 12/30/1899.
				value += DoubleDateOffset; // We could have moved this fix down but we would like to keep the bounds check.
			if (value < OADateMinAsTicks)
				throw new OverflowException("Arg_OleAutDateInvalid");
			// Currently, our max date == OA's max date (12/31/9999), so we don't 
			// need an overflow check in that direction. 
			long millis = (value - DoubleDateOffset) / TicksPerMillisecond;
			if (millis < 0)
			{
				long frac = millis % MillisPerDay;
				if (frac != 0) millis -= (MillisPerDay + frac) * 2;
			}
			return (double)millis / MillisPerDay;
		}

#if !NET46
		public static double ToOADate(this DateTime root)
		{
			return TicksToOADate(root.Ticks);
		}
#endif

		public static string OuterXml(this XElement root)
		{
			using (var reader = root.CreateReader())
			{
				reader.MoveToContent();
				return reader.ReadOuterXml();
			}
		}

		public static string OuterXml(this XNode root)
		{
			using (var reader = root.CreateReader())
			{
				reader.MoveToContent();
				return reader.ReadOuterXml();
			}
		}

		public static string InnerXml(this XElement root)
		{
			using (var reader = root.CreateReader())
			{
				reader.MoveToContent();
				return reader.ReadInnerXml();
			}
		}
		public static string Prefix(this XElement root)
		{
			return root.GetPrefixOfNamespace(root.Name.Namespace);
		}

		public static IEnumerable<XElement> ChildElements(this XElement root)
		{
			foreach (XNode childNode in root.Nodes())
			{
				var elm = childNode as XElement;
				if (elm != null)
				{
					yield return elm;
				}
			}
		}
		public static XElement AddSchemaAttribute(this XElement root, string schema)
		{
			var nsAttribute =
				new XAttribute("xmlns", schema);
			root.Add(nsAttribute);
			return root;
		}

		public static string AttributeValue(this XElement element, string attribute, string sub = null)
		{
			return element.Attribute(attribute).Value ?? sub;
		}

		public static XElement SetAttrValue(this XElement element, string attribute, string value)
		{
			element.SetAttributeValue(attribute, value);
			return element;
			//var attr = element.Attribute(attribute);
			//if (attr == null)
			//{
			//	attr = new XAttribute(attribute, value);
			//}
			//else
			//{
			//	attr.Value = value;
			//}
			//return element;
		}

		/// <summary>
		/// Adds additional schema attributes to the root element
		/// </summary>
		/// <param name="root">The root element</param>
		/// <param name="nameSpace">The namespace of the schema</param>
		/// <param name="schema">The schema to apply</param>
		public static XElement AddSchemaAttribute(this XElement root, XNamespace schema, string nameSpace)
		{
			var nsAttribute =
				new XAttribute(XNamespace.Xmlns + nameSpace, schema);
			root.Add(nsAttribute);
			return root;
		}

		public static XElement SetAttribute(this XElement element, string name, string value)
		{
			element.SetAttributeValue(name, value);
			return element;
		}

		//public static XElement SetAttribute(this XElement root, string name, string value)
		//{
		//	var nsAttribute =
		//		new XAttribute(name, value);
		//	root.Add(nsAttribute);
		//	return root;
		//}

		public static XmlNameTable NameTable(this XDocument doc)
		{
			using (var reader = doc.CreateReader())
			{
				return reader.NameTable;
			}
		}

		public static XElement SetAttribute(this XElement root, string name, XNamespace schema, string value)
		{
			var nsAttribute =
				new XAttribute(schema + name, value);
			root.Add(nsAttribute);
			return root;
		}
	}
}