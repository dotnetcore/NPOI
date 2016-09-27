/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */


using System.Xml.Linq;

namespace NPOI.SS
{
	using System.Collections.Generic;
	using System.Text;
	using System.Xml;

	public class HtmlDocumentFacade
	{
		protected XElement body;
		protected XDocument document;
		protected XElement head;
		protected XElement html;

		//Dictionary from tag name, to map linking known styles and css class names
		private Dictionary<string, Dictionary<string, string>> stylesheet = new Dictionary<string, Dictionary<string, string>>();
		private XElement stylesheetElement;

		protected XElement title;
		protected XText titleText;

		public HtmlDocumentFacade(XDocument document)
		{
			this.document = document;

			html = document.CreateElement("html");
			document.AppendChild(html);

			body = document.CreateElement("body");
			head = document.CreateElement("head");
			stylesheetElement = document.CreateElement("style");
			stylesheetElement.SetAttribute("type", "text/css");

			html.AppendChild(head);
			html.AppendChild(body);
			head.AppendChild(stylesheetElement);
			AddCharset();
			AddStyleClass(body, "b", "white-space-collapsing:preserve;");
		}
		// add by Antony
		// 不写charset，部分浏览器可能无法正确显示
		public void AddCharset()
		{
			XElement meta = document.CreateElement("meta");
			meta.SetAttribute("http-equiv", "Content-Type");
			meta.SetAttribute("content", "text/html; charset=UTF-8");
			head.AppendChild(meta);
		}
		public void AddAuthor(string value)
		{
			AddMeta("author", value);
		}
		public void AddDescription(string value)
		{
			AddMeta("description", value);
		}

		public void AddKeywords(string value)
		{
			AddMeta("keywords", value);
		}

		public void AddMeta(string name, string value)
		{
			XElement meta = document.CreateElement("meta");
			meta.SetAttribute("name", name);
			meta.SetAttribute("content", value);
			head.AppendChild(meta);
		}

		public void AddStyleClass(XElement element, string classNamePrefix, string style)
		{
			string exising = element.GetAttribute("class");
			string addition = GetOrCreateCssClass(element.Name.LocalName, classNamePrefix, style);
			string newClassValue = string.IsNullOrEmpty(exising) ? addition
					: (exising + " " + addition);
			element.GetAttribute("class", newClassValue);
		}

		public XElement CreateBlock()
		{
			return document.CreateElement("div");
		}

		public XElement CreateBookmark(string name)
		{
			XElement basicLink = document.CreateElement("a");
			basicLink.SetAttribute("name", name);
			return basicLink;
		}

		public XElement CreateHeader1()
		{
			return document.CreateElement("h1");
		}

		public XElement CreateHeader2()
		{
			return document.CreateElement("h2");
		}

		public XElement CreateHyperlink(string internalDestination)
		{
			XElement basicLink = document.CreateElement("a");
			basicLink.SetAttribute("href", internalDestination);
			return basicLink;
		}

		public XElement CreateImage(string src)
		{
			XElement result = document.CreateElement("img");
			result.SetAttribute("src", src);
			return result;
		}

		public XElement CreateLineBreak()
		{
			return document.CreateElement("br");
		}

		public XElement CreateListItem()
		{
			return document.CreateElement("li");
		}

		public XElement CreateParagraph()
		{
			return document.CreateElement("p");
		}

		public XElement CreateTable()
		{
			return document.CreateElement("table");
		}

		public XElement CreateTableBody()
		{
			return document.CreateElement("tbody");
		}

		public XElement CreateTableCell()
		{
			return document.CreateElement("td");
		}

		public XElement CreateTableColumn()
		{
			return document.CreateElement("col");
		}

		public XElement CreateTableColumnGroup()
		{
			return document.CreateElement("colgroup");
		}

		public XElement CreateTableHeader()
		{
			return document.CreateElement("thead");
		}

		public XElement CreateTableHeaderCell()
		{
			return document.CreateElement("th");
		}

		public XElement CreateTableRow()
		{
			return document.CreateElement("tr");
		}

		public XText CreateText(string data)
		{
			return new XText(data);
		}

		public XElement CreateUnorderedList()
		{
			return document.CreateElement("ul");
		}
		public XElement Body
		{
			get { return body; }
		}
		public XDocument Document
		{
			get { return document; }
		}
		public XElement Head
		{
			get { return head; }
		}

		public string GetOrCreateCssClass(string tagName, string classNamePrefix,
			string style)
		{
			if (!stylesheet.ContainsKey(tagName))
				stylesheet.Add(tagName, new Dictionary<string, string>(1));

			Dictionary<string, string> styleToClassName = stylesheet[tagName];

			string knownClass;
			if (styleToClassName.ContainsKey(style))
			{
				knownClass = styleToClassName[style];
				return knownClass;
			}

			string newClassName = classNamePrefix + (styleToClassName.Count + 1);
			styleToClassName.Add(style, newClassName);
			return newClassName;
		}

		public string Title
		{
			get
			{
				if (title == null)
					return null;
				return titleText.Value;
			}
			set
			{
				if (string.IsNullOrEmpty(value) && this.title != null)
				{
					this.title.Remove();
					this.title = null;
					this.titleText = null;
				}

				if (this.title == null)
				{
					this.title = document.CreateElement("title");
					this.titleText = new XText(value);
					this.title.AppendChild(this.titleText);
					this.head.AppendChild(title);
				}

				this.titleText.Value = value;
			}
		}

		/*

        public string getTitle()
        {
            if (title == null)
                return null;

            //return titleText.getTextContent();
            return titleText.InnerText;
        }

        public void setTitle(string titleText)
        {
            if (string.IsNullOrEmpty(titleText) && this.title != null)
            {
                //this.head.removeChild(this.title);
                this.title = null;
                this.titleText = null;
            }

            if (this.title == null)
            {
                this.title = document.CreateElement("title");
                this.titleText = document.CreateTextNode(titleText);
                this.title.AppendChild(this.titleText);
                this.head.AppendChild(title);
            }

            //this.titleText.setData(titleText);
            this.titleText.InnerXml = titleText;
        }
         */

		public void UpdateStylesheet()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, Dictionary<string, string>> kvTag in stylesheet)
			{
				string tagName = kvTag.Key;
				foreach (KeyValuePair<string, string> kvStyle in kvTag.Value)
				{
					string style = kvStyle.Key;
					string className = kvStyle.Value;

					stringBuilder.Append(tagName + "." + className + "{" + style
							+ "}\n");
				}
			}
			//stylesheetElement.setTextContent( stringBuilder.toString() );
			stylesheetElement.Value = stringBuilder.ToString();
		}
	}
}
