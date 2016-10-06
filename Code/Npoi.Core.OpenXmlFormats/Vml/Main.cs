using System;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;
using Npoi.Core.OpenXmlFormats.Vml.Wordprocessing;
using Npoi.Core.OpenXmlFormats.Vml.Office;
using Npoi.Core.OpenXmlFormats.Vml.Spreadsheet;
using Npoi.Core.OpenXmlFormats.Vml.Presentation;
using System.IO;
using System.Xml;
using System.Text;
using System.ComponentModel;
using System.Xml.Linq;
using Npoi.Core.OpenXml4Net.Util;

namespace Npoi.Core.OpenXmlFormats.Vml
{
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public class CT_Fill
    {

        private string idField;

        private ST_FillType typeField;

        private bool typeFieldSpecified;

        private ST_TrueFalse onField;

        private bool onFieldSpecified;

        private string colorField;

        private string opacityField;

        private string color2Field;

        private string srcField;

        private string sizeField;

        private string originField;

        private string positionField;

        private ST_ImageAspect aspectField;

        private bool aspectFieldSpecified;

        private string colorsField;

        private decimal angleField;

        private bool angleFieldSpecified;

        private ST_TrueFalse alignshapeField;

        private bool alignshapeFieldSpecified;

        private string focusField;

        private string focussizeField;

        private string focuspositionField;

        private ST_FillMethod methodField;

        private bool methodFieldSpecified;

        private ST_TrueFalse recolorField;

        private bool recolorFieldSpecified;

        private ST_TrueFalse rotateField;

        private bool rotateFieldSpecified;

        //private string id1Field;

        public static CT_Fill Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Fill ctObj = new CT_Fill();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            if (node.Attribute("type") != null)
                ctObj.type = (ST_FillType)Enum.Parse(typeof(ST_FillType), node.Attribute("type").Value);
            if (node.Attribute("on") != null)
                ctObj.on = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("on"));
            ctObj.color = XmlHelper.ReadString(node.Attribute("color"));
            ctObj.opacity = XmlHelper.ReadString(node.Attribute("opacity"));
            ctObj.color2 = XmlHelper.ReadString(node.Attribute("color2"));
            ctObj.src = XmlHelper.ReadString(node.Attribute("src"));
            ctObj.size = XmlHelper.ReadString(node.Attribute("size"));
            ctObj.origin = XmlHelper.ReadString(node.Attribute("origin"));
            ctObj.position = XmlHelper.ReadString(node.Attribute("position"));
            if (node.Attribute("aspect") != null)
                ctObj.aspect = (ST_ImageAspect)Enum.Parse(typeof(ST_ImageAspect), node.Attribute("aspect").Value);
            ctObj.colors = XmlHelper.ReadString(node.Attribute("colors"));
            if (node.Attribute("angle") != null)
                ctObj.angle = XmlHelper.ReadDecimal(node.Attribute("angle"));
            if (node.Attribute("alignshape") != null)
                    ctObj.alignshape = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("alignshape"));
            ctObj.focus = XmlHelper.ReadString(node.Attribute("focus"));
            ctObj.focussize = XmlHelper.ReadString(node.Attribute("focussize"));
            ctObj.focusposition = XmlHelper.ReadString(node.Attribute("focusposition"));
            if (node.Attribute("method") != null)
                ctObj.method = (ST_FillMethod)Enum.Parse(typeof(ST_FillMethod), node.Attribute("method").Value);
            if (node.Attribute("recolor") != null)
                ctObj.recolor = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("recolor"));
            if (node.Attribute("rotate") != null)
                ctObj.rotate = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("rotate"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
            XmlHelper.WriteAttribute(sw, "color", this.color);
            XmlHelper.WriteAttribute(sw, "opacity", this.opacity);
            XmlHelper.WriteAttribute(sw, "color2", this.color2);
            XmlHelper.WriteAttribute(sw, "src", this.src);
            XmlHelper.WriteAttribute(sw, "size", this.size);
            XmlHelper.WriteAttribute(sw, "origin", this.origin);
            XmlHelper.WriteAttribute(sw, "position", this.position);
            XmlHelper.WriteAttribute(sw, "aspect", this.aspect.ToString());
            XmlHelper.WriteAttribute(sw, "colors", this.colors);
            XmlHelper.WriteAttribute(sw, "angle", (double)this.angle);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "alignshape", this.alignshape);
            XmlHelper.WriteAttribute(sw, "focus", this.focus);
            XmlHelper.WriteAttribute(sw, "focussize", this.focussize);
            XmlHelper.WriteAttribute(sw, "focusposition", this.focusposition);
            XmlHelper.WriteAttribute(sw, "method", this.method.ToString());
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "recolor", this.recolor);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "rotate", this.rotate);
            sw.Write(">");
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

        [XmlAttribute]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }


        [XmlAttribute]
        public ST_FillType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }


        [XmlIgnore]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public ST_TrueFalse on
        {
            get
            {
                return this.onField;
            }
            set
            {
                this.onField = value;
            }
        }


        [XmlIgnore]
        public bool onSpecified
        {
            get
            {
                return this.onFieldSpecified;
            }
            set
            {
                this.onFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public string color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }


        [XmlAttribute]
        public string opacity
        {
            get
            {
                return this.opacityField;
            }
            set
            {
                this.opacityField = value;
            }
        }


        [XmlAttribute]
        public string color2
        {
            get
            {
                return this.color2Field;
            }
            set
            {
                this.color2Field = value;
            }
        }


        [XmlAttribute]
        public string src
        {
            get
            {
                return this.srcField;
            }
            set
            {
                this.srcField = value;
            }
        }


        [XmlAttribute]
        public string size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }


        [XmlAttribute]
        public string origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }


        [XmlAttribute]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }


        [XmlAttribute]
        public ST_ImageAspect aspect
        {
            get
            {
                return this.aspectField;
            }
            set
            {
                this.aspectField = value;
            }
        }


        [XmlIgnore]
        public bool aspectSpecified
        {
            get
            {
                return this.aspectFieldSpecified;
            }
            set
            {
                this.aspectFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public string colors
        {
            get
            {
                return this.colorsField;
            }
            set
            {
                this.colorsField = value;
            }
        }


        [XmlAttribute]
        public decimal angle
        {
            get
            {
                return this.angleField;
            }
            set
            {
                this.angleField = value;
            }
        }


        [XmlIgnore]
        public bool angleSpecified
        {
            get
            {
                return this.angleFieldSpecified;
            }
            set
            {
                this.angleFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public ST_TrueFalse alignshape
        {
            get
            {
                return this.alignshapeField;
            }
            set
            {
                this.alignshapeField = value;
            }
        }


        [XmlIgnore]
        public bool alignshapeSpecified
        {
            get
            {
                return this.alignshapeFieldSpecified;
            }
            set
            {
                this.alignshapeFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public string focus
        {
            get
            {
                return this.focusField;
            }
            set
            {
                this.focusField = value;
            }
        }


        [XmlAttribute]
        public string focussize
        {
            get
            {
                return this.focussizeField;
            }
            set
            {
                this.focussizeField = value;
            }
        }


        [XmlAttribute]
        public string focusposition
        {
            get
            {
                return this.focuspositionField;
            }
            set
            {
                this.focuspositionField = value;
            }
        }


        [XmlAttribute]
        public ST_FillMethod method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }


        [XmlIgnore]
        public bool methodSpecified
        {
            get
            {
                return this.methodFieldSpecified;
            }
            set
            {
                this.methodFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public ST_TrueFalse recolor
        {
            get
            {
                return this.recolorField;
            }
            set
            {
                this.recolorField = value;
            }
        }


        [XmlIgnore]
        public bool recolorSpecified
        {
            get
            {
                return this.recolorFieldSpecified;
            }
            set
            {
                this.recolorFieldSpecified = value;
            }
        }


        [XmlAttribute]
        public ST_TrueFalse rotate
        {
            get
            {
                return this.rotateField;
            }
            set
            {
                this.rotateField = value;
            }
        }


        [XmlIgnore]
        public bool rotateSpecified
        {
            get
            {
                return this.rotateFieldSpecified;
            }
            set
            {
                this.rotateFieldSpecified = value;
            }
        }
    }


    [Serializable]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public enum ST_FillType
    {


        solid,


        gradient,


        gradientRadial,


        tile,


        pattern,


        frame,
    }


    [Serializable]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public enum ST_TrueFalse
    {

        f,
        t,
        @true,
        @false,
    }


    [Serializable]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public enum ST_ImageAspect
    {


        ignore,


        atMost,


        atLeast,
    }


    [Serializable]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public enum ST_FillMethod
    {


        none,


        linear,


        sigma,


        any,


        [XmlEnum("linear sigma")]
        linearsigma,
    }
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot("shape",Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class  CT_Shape {
        
        
        private string typeField;
        
        private string adjField;
        private string styleField;
        private CT_Path pathField;
        
        private string equationxmlField;

        private string idField;
        private string fillcolorField;
        private ST_InsetMode insetmodeField;

        private ST_TrueFalse strokedField;
        private string wrapcoordsField;

        public static CT_Shape Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Shape ctObj = new CT_Shape();
            ctObj.wrapcoords = XmlHelper.ReadString(node.Attribute("wrapcoords"));
            if (node.Attribute("stroked") != null)
                ctObj.stroked = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("stroked"));
            ctObj.spid = XmlHelper.ReadString(node.Attribute("o:spid"));
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            ctObj.fillcolor = XmlHelper.ReadString(node.Attribute("fillcolor"));
            if (node.Attribute("o:insetmode") != null)
                ctObj.insetmode = (ST_InsetMode)Enum.Parse(typeof(ST_InsetMode), node.Attribute("o:insetmode").Value);
            ctObj.type = XmlHelper.ReadString(node.Attribute("type"));
            ctObj.adj = XmlHelper.ReadString(node.Attribute("adj"));
            ctObj.equationxml = XmlHelper.ReadString(node.Attribute("equationxml"));
            ctObj.style = XmlHelper.ReadString(node.Attribute("style"));
            ctObj.ClientData = new List<CT_ClientData>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "textdata")
                    ctObj.textdata = CT_Rel.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "anchorlock")
                    ctObj.anchorlock = new CT_AnchorLock();
                else if (childNode.Name.LocalName == "borderright")
                    ctObj.borderright = CT_Border.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "borderleft")
                    ctObj.borderleft = CT_Border.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "borderbottom")
                    ctObj.borderbottom = CT_Border.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "bordertop")
                    ctObj.bordertop = CT_Border.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "iscomment")
                    ctObj.iscomment = new CT_Empty();
                else if (childNode.Name.LocalName == "stroke")
                    ctObj.stroke = CT_Stroke.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "wrap")
                    ctObj.wrap = CT_Wrap.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "textbox")
                    ctObj.textbox = CT_Textbox.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "fill")
                    ctObj.fill = CT_Fill.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "formulas")
                    ctObj.formulas = CT_Formulas.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "handles")
                    ctObj.handles = CT_Handles.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "imagedata")
                    ctObj.imagedata = CT_ImageData.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "lock")
                    ctObj.@lock = CT_Lock.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "shadow")
                    ctObj.shadow = CT_Shadow.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "path")
                    ctObj.path = CT_Path.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "textpath")
                    ctObj.textpath = CT_TextPath.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "ClientData")
                    ctObj.ClientData.Add(CT_ClientData.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        public void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "wrapcoords", this.wrapcoords);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "stroked", this.stroked);
            XmlHelper.WriteAttribute(sw, "o:spid", this.spid);
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "fillcolor", this.fillcolor);
            XmlHelper.WriteAttribute(sw, "o:insetmode", this.insetmode.ToString());
            XmlHelper.WriteAttribute(sw, "type", this.type);
            XmlHelper.WriteAttribute(sw, "adj", this.adj);
            XmlHelper.WriteAttribute(sw, "equationxml", this.equationxml);
            XmlHelper.WriteAttribute(sw, "style", this.style);
            sw.Write(">");

            if (this.iscomment != null)
                sw.Write("<iscomment/>");
            if (this.stroke != null)
                this.stroke.Write(sw, "stroke");
            if (this.wrap != null)
                this.wrap.Write(sw, "wrap");
            if (this.fill != null)
                this.fill.Write(sw, "fill");
            if (this.formulas != null)
                this.formulas.Write(sw, "formulas");
            if (this.handles != null)
                this.handles.Write(sw, "handles");
            if (this.imagedata != null)
                this.imagedata.Write(sw, "imagedata");
            if (this.@lock != null)
                this.@lock.Write(sw, "lock");
            if (this.shadow != null)
                this.shadow.Write(sw, "shadow");
            if (this.path != null)
                this.path.Write(sw, "path");
            if (this.textpath != null)
                this.textpath.Write(sw, "textpath");
            if (this.textbox != null)
                this.textbox.Write(sw, "textbox");
            if (this.textdata != null)
                this.textdata.Write(sw, "textdata");
            if (this.anchorlock != null)
                sw.Write("<w:anchorlock/>");
            if (this.borderright != null)
                this.borderright.Write(sw, "borderright");
            if (this.borderleft != null)
                this.borderleft.Write(sw, "borderleft");
            if (this.borderbottom != null)
                this.borderbottom.Write(sw, "borderbottom");
            if (this.bordertop != null)
                this.bordertop.Write(sw, "bordertop");
            if (this.ClientData != null)
            {
                foreach (CT_ClientData x in this.ClientData)
                {
                    x.Write(sw, "ClientData");
                }
            }
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

        [XmlAttribute]
        public string wrapcoords
        {
            get { return wrapcoordsField; }
            set { wrapcoordsField = value; }
        }
        [XmlAttribute]
        [DefaultValue(ST_TrueFalse.t)]
        public ST_TrueFalse stroked
        {
            get { return strokedField; }
            set { strokedField = value; }
        }


        //static XmlSerializer serializer = new XmlSerializer(typeof(CT_Shape), "urn:schemas-microsoft-com:vml");
        //public static CT_Shape Parse(string xmltext)
        //{
        //    TextReader tr = new StringReader(xmltext);
        //    CT_Shape obj = (CT_Shape)serializer.Deserialize(tr);
        //    return obj;
        //}
        private string spidField;

        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public string spid
        {
            get { return this.spidField; }
            set { this.spidField = value; }
        }
        [XmlAttribute]
        public string id
        {
            get { return idField; }
            set { idField = value; }
        }

        [XmlAttribute]
        public string fillcolor
        {
            get { return fillcolorField; }
            set { fillcolorField = value; }
        }

        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        [DefaultValue(ST_InsetMode.auto)]
        public ST_InsetMode insetmode
        {
            get { return insetmodeField; }
            set { insetmodeField = value; }
        }

        public CT_Textbox AddNewTextbox()
        {
            textboxField = new CT_Textbox();
            return this.textboxField;
            }

        private CT_Wrap wrapField;
        private CT_Fill fillField;
        private CT_Formulas formulasField;
        private CT_Handles handlesField;
        private CT_ImageData imagedataField;
        private CT_Stroke strokeField;
        private CT_Shadow shadowField;
        private CT_Textbox textboxField;
        private CT_TextPath textpathField;
        private CT_Empty iscommentField;
        private CT_Lock lockField;
        private CT_Border bordertopField;
        private CT_Border borderrightField;
        private CT_Border borderleftField;
        private CT_Border borderbottomField;
        private CT_AnchorLock anchorlockField;
        private CT_Rel textdataField;

        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
        public CT_Rel textdata
        {
            get { return this.textdataField; }
            set { this.textdataField = value; }
        }
        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
        public CT_AnchorLock anchorlock
        {
            get { return this.anchorlockField; }
            set { this.anchorlockField = value; }
        }
        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
        public CT_Border borderright
        {
            get { return this.borderrightField; }
            set { this.borderrightField = value; }
        }
        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
        public CT_Border borderleft
        {
            get { return this.borderleftField; }
            set { this.borderleftField = value; }
        }
        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
        public CT_Border borderbottom
        {
            get { return this.borderbottomField; }
            set { this.borderbottomField = value; }
        }
        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:word")]
        public CT_Border bordertop
        {
            get { return this.bordertopField; }
            set { this.bordertopField = value; }
        }
        [XmlElement(Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
        public CT_Empty iscomment
        {
            get { return this.iscommentField; }
            set { this.iscommentField = value; }
        }
        [XmlElement]
        public CT_Stroke stroke
        {
            get { return this.strokeField; }
            set { this.strokeField = value; }
        }


        [XmlElement(Namespace="urn:schemas-microsoft-com:office:word")]
        public CT_Wrap wrap
        {
            get { return this.wrapField; }
            set { this.wrapField = value; }
        }
        [XmlElement]
        public CT_Textbox textbox
        {
            get { return this.textboxField; }
            set { this.textboxField = value; }
        }
        [XmlElement]
        public CT_Fill fill
        {
            get { return this.fillField; }
            set { this.fillField = value; }
        }
        [XmlElement]
        public CT_Formulas formulas
        {
            get { return this.formulasField; }
            set { this.formulasField = value; }
        }
        [XmlElement]
        public CT_Handles handles
        {
            get { return this.handlesField; }
            set { this.handlesField = value; }
        }
        [XmlElement]
        public CT_ImageData imagedata
        {
            get { return this.imagedataField; }
            set { this.imagedataField = value; }
        }
        [XmlElement(ElementName = "lock", Namespace = "urn:schemas-microsoft-com:office:office")]
        public CT_Lock @lock
        {
            get
            {
                return this.lockField;
            }
            set
            {
                this.lockField = value;
            }
        }

        [XmlElement]
        public CT_Shadow shadow
        {
            get { return this.shadowField; }
            set { this.shadowField = value; }
        }

        public CT_Fill AddNewFill()
        {
            this.fillField=new CT_Fill();
            return this.fillField;
        }
        public CT_Shadow AddNewShadow()
        {
            this.shadowField = new CT_Shadow();
            return this.shadowField;
        }
        public CT_Path AddNewPath()
        {
            this.pathField = new CT_Path();
            return this.pathField;       
        }
        List<CT_ClientData> clientDataField = null;

        [XmlElement("ClientData",Namespace = "urn:schemas-microsoft-com:office:excel")]
        public List<CT_ClientData> ClientData
        {
            get
            {
                return clientDataField;
            }
            set
            {
                    this.clientDataField = value;
            }
        }
        public CT_ClientData GetClientDataArray(int index)
        {
            return clientDataField != null ? this.clientDataField[index] : null;
        }
        public int sizeOfClientDataArray()
        {
            if (clientDataField == null)
                return 0;
            return clientDataField.Count;
        }
        public CT_ClientData AddNewClientData()
        {
            CT_ClientData cd=new CT_ClientData();
            if (clientDataField == null)
                this.clientDataField = new List<CT_ClientData>();
            this.clientDataField.Add(cd);
            return cd;
        }
        
        
        [XmlAttribute]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        
        [XmlAttribute]
        public string adj {
            get {
                return this.adjField;
            }
            set {
                this.adjField = value;
            }
        }
        
        
        [XmlElement]
        public CT_Path path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        
        [XmlAttribute]
        public string equationxml {
            get {
                return this.equationxmlField;
            }
            set {
                this.equationxmlField = value;
            }
        }
        [XmlAttribute]
        public string style
        {
            get 
            {
                return this.styleField;
            }
            set 
            {
                this.styleField = value;
            }
        }
        //internal static XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces(new XmlQualifiedName[] {
        //    new XmlQualifiedName("o", "urn:schemas-microsoft-com:office:office"),
        //    new XmlQualifiedName("x", "urn:schemas-microsoft-com:office:excel"),
        //    new XmlQualifiedName("v", "urn:schemas-microsoft-com:vml")
        //});

        //public override string ToString()
        //{
        //    using (StringWriter stringWriter = new StringWriter())
        //    {
        //        XmlWriterSettings settings = new XmlWriterSettings();
                
        //        settings.Encoding = Encoding.UTF8;
        //        settings.OmitXmlDeclaration = true;

        //        using (XmlWriter writer = XmlWriter.Create(stringWriter, settings))
        //        {
        //            serializer.Serialize(writer, this, namespaces);
        //        }
        //        return stringWriter.ToString();
        //    }
        //}
        [XmlElement]
        public CT_TextPath textpath
        {
            get
            {
                return this.textpathField;
            }
            set
            {
                this.textpathField = value;
            }
        }

        public CT_TextPath AddNewTextpath()
        {
            this.textpathField = new CT_TextPath();
            return this.textpathField;
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public class CT_Formulas
    {
        private List<CT_F> fField = null; // 0..* 

       
        [XmlElement("f", Form = XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
        public List<CT_F> f
        {
            get { return this.fField; }
            set { this.fField = value; }
        }
        [XmlIgnore]
        public bool fSpecified
        {
            get { return (null != fField); }
        }

        public CT_F AddNewF()
        {
            if (this.fField == null)
                this.fField = new List<CT_F>();
            this.fField.Add(new CT_F());
            return this.fField[this.fField.Count - 1];
        }

        public static CT_Formulas Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Formulas ctObj = new CT_Formulas();
            ctObj.f = new List<CT_F>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "f")
                    ctObj.f.Add(CT_F.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            sw.Write(">");
            if (this.f != null)
            {
                foreach (CT_F x in this.f)
                {
                    x.Write(sw, "f");
                }
            }
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

    }


    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public class CT_F
    {
        private string eqnField = null;

        [XmlAttribute]
        public string eqn
        {
            get { return this.eqnField; }
            set { this.eqnField = value; }
        }
        [XmlIgnore]
        public bool eqnSpecified
        {
            get { return (null != eqnField); }
        }
        public static CT_F Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_F ctObj = new CT_F();
            ctObj.eqn = XmlHelper.ReadString(node.Attribute("eqn"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "eqn", this.eqn);
            sw.Write("/>");
        }

    }


    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
    public class CT_Handles
    {

        private List<CT_H> hField = null;

        [XmlElement("h")]
        public List<CT_H> h
        {
            get { return this.hField; }
            set { this.hField = value; }
        }
        [XmlIgnore]
        public bool hSpecified
        {
            get { return (null != hField); }
        }

        public CT_H AddNewH()
        {
            if (hField == null)
                hField = new List<CT_H>();
            CT_H h = new CT_H();
            hField.Add(h);
            return h;
        }

        public static CT_Handles Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Handles ctObj = new CT_Handles();
            ctObj.h = new List<CT_H>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "h")
                    ctObj.h.Add(CT_H.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            sw.Write(">");
            if (this.h != null)
            {
                foreach (CT_H x in this.h)
                {
                    x.Write(sw, "h");
                }
            }
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    public class CT_H {
        
        private string positionField;
        
        private string polarField;
        
        private string mapField;
        
        private ST_TrueFalse invxField;
        
        private bool invxFieldSpecified;
        
        private ST_TrueFalse invyField;
        
        private bool invyFieldSpecified; // TODO remove
        
        private ST_TrueFalseBlank switchField;
        
        private bool switchFieldSpecified;
        
        private string xrangeField;
        
        private string yrangeField;
        
        private string radiusrangeField;
        
        
        [XmlAttribute]
        public string position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
            }
        }
        
        
        [XmlAttribute]
        public string polar {
            get {
                return this.polarField;
            }
            set {
                this.polarField = value;
            }
        }
        
        
        [XmlAttribute]
        public string map {
            get {
                return this.mapField;
            }
            set {
                this.mapField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse invx {
            get {
                return this.invxField;
            }
            set {
                this.invxField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool invxSpecified {
            get {
                return this.invxFieldSpecified;
            }
            set {
                this.invxFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse invy {
            get {
                return this.invyField;
            }
            set {
                this.invyField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool invySpecified {
            get {
                return this.invyFieldSpecified;
            }
            set {
                this.invyFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalseBlank @switch {
            get {
                return this.switchField;
            }
            set {
                this.switchField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool switchSpecified {
            get {
                return this.switchFieldSpecified;
            }
            set {
                this.switchFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string xrange {
            get {
                return this.xrangeField;
            }
            set {
                this.xrangeField = value;
            }
        }
        
        
        [XmlAttribute]
        public string yrange {
            get {
                return this.yrangeField;
            }
            set {
                this.yrangeField = value;
            }
        }
        
        
        [XmlAttribute]
        public string radiusrange {
            get {
                return this.radiusrangeField;
            }
            set {
                this.radiusrangeField = value;
            }
        }
        public static CT_H Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_H ctObj = new CT_H();
            ctObj.position = XmlHelper.ReadString(node.Attribute("position"));
            ctObj.polar = XmlHelper.ReadString(node.Attribute("polar"));
            ctObj.map = XmlHelper.ReadString(node.Attribute("map"));
            if (node.Attribute("invx") != null)
                ctObj.invx = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("invx"));
            if (node.Attribute("invy") != null)
                ctObj.invy = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("invy"));
            if (node.Attribute("switch") != null)
                ctObj.@switch = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalseBlank(node.Attribute("switch"));
            ctObj.xrange = XmlHelper.ReadString(node.Attribute("xrange"));
            ctObj.yrange = XmlHelper.ReadString(node.Attribute("yrange"));
            ctObj.radiusrange = XmlHelper.ReadString(node.Attribute("radiusrange"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "position", this.position);
            XmlHelper.WriteAttribute(sw, "polar", this.polar);
            XmlHelper.WriteAttribute(sw, "map", this.map);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "invx", this.invx);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "invy", this.invy);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "switch", this.@switch);
            XmlHelper.WriteAttribute(sw, "xrange", this.xrange);
            XmlHelper.WriteAttribute(sw, "yrange", this.yrange);
            XmlHelper.WriteAttribute(sw, "radiusrange", this.radiusrange);
            sw.Write(">");
            sw.Write(string.Format("</v:{0}>", nodeName));
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_ImageData {


        private string relidField;
        private string titleField;
        private string oleidField;
        private string movieField;
        private string idField;
        
        private string srcField;
        
        private string cropleftField;
        
        private string croptopField;
        
        private string croprightField;
        
        private string cropbottomField;
        
        private string gainField;
        
        private string blacklevelField;
        
        private string gammaField;
        
        private ST_TrueFalse grayscaleField;
        
        private bool grayscaleFieldSpecified;
        
        private ST_TrueFalse bilevelField;
        
        private bool bilevelFieldSpecified;
        
        private string chromakeyField;
        
        private string embosscolorField;
        
        private string recolortargetField;
        
        //private string id1Field;
        
        private string pictField;
        
        private string hrefField;

        public static CT_ImageData Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_ImageData ctObj = new CT_ImageData();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            ctObj.src = XmlHelper.ReadString(node.Attribute("src"));
            ctObj.cropleft = XmlHelper.ReadString(node.Attribute("cropleft"));
            ctObj.croptop = XmlHelper.ReadString(node.Attribute("croptop"));
            ctObj.cropright = XmlHelper.ReadString(node.Attribute("cropright"));
            ctObj.cropbottom = XmlHelper.ReadString(node.Attribute("cropbottom"));
            ctObj.gain = XmlHelper.ReadString(node.Attribute("gain"));
            ctObj.blacklevel = XmlHelper.ReadString(node.Attribute("blacklevel"));
            ctObj.gamma = XmlHelper.ReadString(node.Attribute("gamma"));
            if (node.Attribute("grayscale") != null)
                ctObj.grayscale = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("grayscale"));
            if (node.Attribute("bilevel") != null)
                ctObj.bilevel = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("bilevel"));
            ctObj.chromakey = XmlHelper.ReadString(node.Attribute("chromakey"));
            ctObj.embosscolor = XmlHelper.ReadString(node.Attribute("embosscolor"));
            ctObj.recolortarget = XmlHelper.ReadString(node.Attribute("recolortarget"));
            ctObj.pict = XmlHelper.ReadString(node.Attribute("pict"));
            ctObj.href = XmlHelper.ReadString(node.Attribute("r:href"));
            ctObj.relid = XmlHelper.ReadString(node.Attribute("o:relid"));
            ctObj.title = XmlHelper.ReadString(node.Attribute("o:title"));
            ctObj.movie = XmlHelper.ReadString(node.Attribute("o:movie"));
            ctObj.oleid = XmlHelper.ReadString(node.Attribute("o:oleid"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "src", this.src);
            XmlHelper.WriteAttribute(sw, "cropleft", this.cropleft);
            XmlHelper.WriteAttribute(sw, "croptop", this.croptop);
            XmlHelper.WriteAttribute(sw, "cropright", this.cropright);
            XmlHelper.WriteAttribute(sw, "cropbottom", this.cropbottom);
            XmlHelper.WriteAttribute(sw, "gain", this.gain);
            XmlHelper.WriteAttribute(sw, "blacklevel", this.blacklevel);
            XmlHelper.WriteAttribute(sw, "gamma", this.gamma);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "grayscale", this.grayscale);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "bilevel", this.bilevel);
            XmlHelper.WriteAttribute(sw, "chromakey", this.chromakey);
            XmlHelper.WriteAttribute(sw, "embosscolor", this.embosscolor);
            XmlHelper.WriteAttribute(sw, "recolortarget", this.recolortarget);
            XmlHelper.WriteAttribute(sw, "pict", this.pict);
            XmlHelper.WriteAttribute(sw, "r:href", this.href);
            XmlHelper.WriteAttribute(sw, "o:relid", this.relid);
            XmlHelper.WriteAttribute(sw, "o:title", this.title);
            XmlHelper.WriteAttribute(sw, "o:movie", this.movie);
            XmlHelper.WriteAttribute(sw, "o:oleid", this.oleid);
            sw.Write("/>");
        }

        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [XmlAttribute]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
            }
        }
        
        
        [XmlAttribute]
        public string cropleft {
            get {
                return this.cropleftField;
            }
            set {
                this.cropleftField = value;
            }
        }
        
        
        [XmlAttribute]
        public string croptop {
            get {
                return this.croptopField;
            }
            set {
                this.croptopField = value;
            }
        }
        
        
        [XmlAttribute]
        public string cropright {
            get {
                return this.croprightField;
            }
            set {
                this.croprightField = value;
            }
        }
        
        
        [XmlAttribute]
        public string cropbottom {
            get {
                return this.cropbottomField;
            }
            set {
                this.cropbottomField = value;
            }
        }
        
        
        [XmlAttribute]
        public string gain {
            get {
                return this.gainField;
            }
            set {
                this.gainField = value;
            }
        }
        
        
        [XmlAttribute]
        public string blacklevel {
            get {
                return this.blacklevelField;
            }
            set {
                this.blacklevelField = value;
            }
        }
        
        
        [XmlAttribute]
        public string gamma {
            get {
                return this.gammaField;
            }
            set {
                this.gammaField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse grayscale {
            get {
                return this.grayscaleField;
            }
            set {
                this.grayscaleField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool grayscaleSpecified {
            get {
                return this.grayscaleFieldSpecified;
            }
            set {
                this.grayscaleFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse bilevel {
            get {
                return this.bilevelField;
            }
            set {
                this.bilevelField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool bilevelSpecified {
            get {
                return this.bilevelFieldSpecified;
            }
            set {
                this.bilevelFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string chromakey {
            get {
                return this.chromakeyField;
            }
            set {
                this.chromakeyField = value;
            }
        }
        
        
        [XmlAttribute]
        public string embosscolor {
            get {
                return this.embosscolorField;
            }
            set {
                this.embosscolorField = value;
            }
        }
        
        
        [XmlAttribute]
        public string recolortarget {
            get {
                return this.recolortargetField;
            }
            set {
                this.recolortargetField = value;
            }
        }
        
        
        [XmlAttribute]//(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        public string pict {
            get {
                return this.pictField;
            }
            set {
                this.pictField = value;
            }
        }
        
        
        [XmlAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
        public string href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }

        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public string relid
        {
            get
            {
                return this.relidField;
            }
            set
            {
                this.relidField = value;
            }
        }
        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public string movie
        {
            get
            {
                return this.movieField;
            }
            set
            {
                this.movieField = value;
            }
        }
        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public string oleid
        {
            get {
                return this.oleidField;
            }
            set 
            {
                this.oleidField = value;
            }
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Path {
        
        private string idField;
        
        private string vField;
        
        private string limoField;
        
        private string textboxrectField;
        
        private ST_TrueFalse fillokField;
        
        private bool fillokFieldSpecified;
        
        private ST_TrueFalse strokeokField;
        
        private bool strokeokFieldSpecified;
        
        private ST_TrueFalse shadowokField;
        
        private bool shadowokFieldSpecified;
        
        private ST_TrueFalse arrowokField;
        
        private bool arrowokFieldSpecified;
        
        private ST_TrueFalse gradientshapeokField;
        
        private bool gradientshapeokFieldSpecified;
        
        private ST_TrueFalse textpathokField;
        
        private bool textpathokFieldSpecified;
        
        private ST_TrueFalse insetpenokField;
        
        private bool insetpenokFieldSpecified;

        private ST_ConnectType connecttypeField;

        private string connectlocsField;

        private bool connectlocsFieldSpecified;

        private string connectanglesField;

        private bool connectanglesFieldSpecified;

        private ST_TrueFalse extrusionokField;

        private bool extrusionokFieldSpecified;

        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public ST_ConnectType connecttype
        {
            get
            {
                return this.connecttypeField;
            }
            set
            {
                this.connecttypeField = value;
            }
        }
        
        [XmlAttribute]
        public string v {
            get {
                return this.vField;
            }
            set {
                this.vField = value;
            }
        }
        
        
        [XmlAttribute]
        public string limo {
            get {
                return this.limoField;
            }
            set {
                this.limoField = value;
            }
        }
        
        
        [XmlAttribute]
        public string textboxrect {
            get {
                return this.textboxrectField;
            }
            set {
                this.textboxrectField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse fillok {
            get {
                return this.fillokField;
            }
            set {
                this.fillokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool fillokSpecified {
            get {
                return this.fillokFieldSpecified;
            }
            set {
                this.fillokFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse strokeok {
            get {
                return this.strokeokField;
            }
            set {
                this.strokeokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool strokeokSpecified {
            get {
                return this.strokeokFieldSpecified;
            }
            set {
                this.strokeokFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse shadowok {
            get {
                return this.shadowokField;
            }
            set {
                this.shadowokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool shadowokSpecified {
            get {
                return this.shadowokFieldSpecified;
            }
            set {
                this.shadowokFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse arrowok {
            get {
                return this.arrowokField;
            }
            set {
                this.arrowokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool arrowokSpecified {
            get {
                return this.arrowokFieldSpecified;
            }
            set {
                this.arrowokFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse gradientshapeok {
            get {
                return this.gradientshapeokField;
            }
            set {
                this.gradientshapeokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool gradientshapeokSpecified {
            get {
                return this.gradientshapeokFieldSpecified;
            }
            set {
                this.gradientshapeokFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse textpathok {
            get {
                return this.textpathokField;
            }
            set {
                this.textpathokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool textpathokSpecified {
            get {
                return this.textpathokFieldSpecified;
            }
            set {
                this.textpathokFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse insetpenok {
            get {
                return this.insetpenokField;
            }
            set {
                this.insetpenokField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool insetpenokSpecified {
            get {
                return this.insetpenokFieldSpecified;
            }
            set {
                this.insetpenokFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string connectlocs
        {
            get
            {
                return this.connectlocsField;
            }
            set
            {
                this.connectlocsField = value;
            }
        }
        [XmlIgnore]
        public bool connectlocsSpecified
        {
            get
            {
                return this.connectlocsFieldSpecified;
            }
            set
            {
                this.connectlocsFieldSpecified = value;
            }
        }
        [XmlAttribute]
        public string connectangles
        {
            get
            {
                return this.connectanglesField;
            }
            set
            {
                this.connectanglesField = value;
            }
        }
        [XmlIgnore]
        public bool connectanglesSpecified
        {
            get
            {
                return this.connectanglesFieldSpecified;
            }
            set
            {
                this.connectanglesFieldSpecified = value;
            }
        }
        [XmlAttribute(Namespace="urn:schemas-microsoft-com:office:office")]
        public ST_TrueFalse extrusionok
        {
            get
            {
                return this.extrusionokField;
            }
            set
            {
                this.extrusionokField = value;
            }
        }
        [XmlIgnore]
        public bool extrusionokSpecified
        {
            get
            {
                return this.extrusionokFieldSpecified;
            }
            set
            {
                this.extrusionokFieldSpecified = value;
            }
        }
        public static CT_Path Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Path ctObj = new CT_Path();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            if (node.Attribute("o:connecttype") != null)
                ctObj.connecttype = (ST_ConnectType)Enum.Parse(typeof(ST_ConnectType), node.Attribute("o:connecttype").Value);
            ctObj.v = XmlHelper.ReadString(node.Attribute("v"));
            ctObj.limo = XmlHelper.ReadString(node.Attribute("limo"));
            ctObj.textboxrect = XmlHelper.ReadString(node.Attribute("textboxrect"));
            if (node.Attribute("fillok") != null)
                ctObj.fillok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("fillok"));
            if (node.Attribute("strokeok") != null)
                ctObj.strokeok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("strokeok"));
            if (node.Attribute("shadowok") != null)
                ctObj.shadowok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("shadowok"));
            if (node.Attribute("arrowok") != null)
                ctObj.arrowok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("arrowok"));
            if (node.Attribute("gradientshapeok") != null)
                ctObj.gradientshapeok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("gradientshapeok"));
            if (node.Attribute("textpathok") != null)
                ctObj.textpathok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("textpathok"));
            if (node.Attribute("insetpenok") != null)
                ctObj.insetpenok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("insetpenok"));
            ctObj.connectlocs = XmlHelper.ReadString(node.Attribute("connectlocs"));
            ctObj.connectangles = XmlHelper.ReadString(node.Attribute("connectangles"));
            if (node.Attribute("o:extrusionok") != null)
                ctObj.extrusionok = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("o:extrusionok"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "o:connecttype", this.connecttype.ToString());
            XmlHelper.WriteAttribute(sw, "v", this.v);
            XmlHelper.WriteAttribute(sw, "limo", this.limo);
            XmlHelper.WriteAttribute(sw, "textboxrect", this.textboxrect);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "fillok", this.fillok);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "strokeok", this.strokeok);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "shadowok", this.shadowok);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "arrowok", this.arrowok);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "gradientshapeok", this.gradientshapeok);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "textpathok", this.textpathok);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "insetpenok", this.insetpenok);
            XmlHelper.WriteAttribute(sw, "connectlocs", this.connectlocs);
            XmlHelper.WriteAttribute(sw, "connectangles", this.connectangles);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "o:extrusionok", this.extrusionok, false);
            sw.Write(">");
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Shadow {
        
        private string idField;
        
        private ST_TrueFalse onField;
        
        private bool onFieldSpecified;
        
        private ST_ShadowType typeField;
        
        private bool typeFieldSpecified;
        
        private ST_TrueFalse obscuredField;
        
        private bool obscuredFieldSpecified;
        
        private string colorField;
        
        private string opacityField;
        
        private string offsetField;
        
        private string color2Field;
        
        private string offset2Field;
        
        private string originField;
        
        private string matrixField;
        public static CT_Shadow Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Shadow ctObj = new CT_Shadow();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            if (node.Attribute("on") != null)
                ctObj.on = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("on"));
            if (node.Attribute("type") != null)
                ctObj.type = (ST_ShadowType)Enum.Parse(typeof(ST_ShadowType), node.Attribute("type").Value);
            if (node.Attribute("obscured") != null)
                ctObj.obscured = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("obscured"));
            ctObj.color = XmlHelper.ReadString(node.Attribute("color"));
            ctObj.opacity = XmlHelper.ReadString(node.Attribute("opacity"));
            ctObj.offset = XmlHelper.ReadString(node.Attribute("offset"));
            ctObj.color2 = XmlHelper.ReadString(node.Attribute("color2"));
            ctObj.offset2 = XmlHelper.ReadString(node.Attribute("offset2"));
            ctObj.origin = XmlHelper.ReadString(node.Attribute("origin"));
            ctObj.matrix = XmlHelper.ReadString(node.Attribute("matrix"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
            XmlHelper.WriteAttribute(sw, "type", this.type.ToString());
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "obscured", this.obscured);
            XmlHelper.WriteAttribute(sw, "color", this.color);
            XmlHelper.WriteAttribute(sw, "opacity", this.opacity);
            XmlHelper.WriteAttribute(sw, "offset", this.offset);
            XmlHelper.WriteAttribute(sw, "color2", this.color2);
            XmlHelper.WriteAttribute(sw, "offset2", this.offset2);
            XmlHelper.WriteAttribute(sw, "origin", this.origin);
            XmlHelper.WriteAttribute(sw, "matrix", this.matrix);
            sw.Write(">");
            sw.Write(string.Format("</v:{0}>", nodeName));
        }


        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse on {
            get {
                return this.onField;
            }
            set {
                this.onField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool onSpecified {
            get {
                return this.onFieldSpecified;
            }
            set {
                this.onFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_ShadowType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse obscured {
            get {
                return this.obscuredField;
            }
            set {
                this.obscuredField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool obscuredSpecified {
            get {
                return this.obscuredFieldSpecified;
            }
            set {
                this.obscuredFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
        
        
        [XmlAttribute]
        public string opacity {
            get {
                return this.opacityField;
            }
            set {
                this.opacityField = value;
            }
        }
        
        
        [XmlAttribute]
        public string offset {
            get {
                return this.offsetField;
            }
            set {
                this.offsetField = value;
            }
        }
        
        
        [XmlAttribute]
        public string color2 {
            get {
                return this.color2Field;
            }
            set {
                this.color2Field = value;
            }
        }
        
        
        [XmlAttribute]
        public string offset2 {
            get {
                return this.offset2Field;
            }
            set {
                this.offset2Field = value;
            }
        }
        
        
        [XmlAttribute]
        public string origin {
            get {
                return this.originField;
            }
            set {
                this.originField = value;
            }
        }
        
        
        [XmlAttribute]
        public string matrix {
            get {
                return this.matrixField;
            }
            set {
                this.matrixField = value;
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_ShadowType {
        
        
        single,
        
        
        @double,
        
        
        emboss,
        
        
        perspective,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Stroke {
        
        private string idField;
        
        private ST_TrueFalse onField;
        
        private bool onFieldSpecified;
        
        private string weightField;
        
        private string colorField;
        
        private string opacityField;
        
        private ST_StrokeLineStyle linestyleField;
        
        private bool linestyleFieldSpecified;
        
        private decimal miterlimitField;
        
        private bool miterlimitFieldSpecified;
        
        private ST_StrokeJoinStyle joinstyleField;
        
        private bool joinstyleFieldSpecified;
        
        private ST_StrokeEndCap endcapField;
        
        private bool endcapFieldSpecified;
        
        private string dashstyleField;
        
        private ST_FillType filltypeField;
        
        private bool filltypeFieldSpecified;
        
        private string srcField;
        
        private ST_ImageAspect imageaspectField;
        
        private bool imageaspectFieldSpecified;
        
        private string imagesizeField;
        
        private ST_TrueFalse imagealignshapeField;
        
        private bool imagealignshapeFieldSpecified;
        
        private string color2Field;
        
        private ST_StrokeArrowType startarrowField;
        
        private bool startarrowFieldSpecified;
        
        private ST_StrokeArrowWidth startarrowwidthField;
        
        private bool startarrowwidthFieldSpecified;
        
        private ST_StrokeArrowLength startarrowlengthField;
        
        private bool startarrowlengthFieldSpecified;
        
        private ST_StrokeArrowType endarrowField;
        
        private bool endarrowFieldSpecified;
        
        private ST_StrokeArrowWidth endarrowwidthField;
        
        private bool endarrowwidthFieldSpecified;
        
        private ST_StrokeArrowLength endarrowlengthField;
        
        private bool endarrowlengthFieldSpecified;
        
        //private string id1Field;
        
        private ST_TrueFalse insetpenField;
        
        private bool insetpenFieldSpecified;

        public static CT_Stroke Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Stroke ctObj = new CT_Stroke();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            if (node.Attribute("on") != null)
                ctObj.on = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("on"));
            ctObj.weight = XmlHelper.ReadString(node.Attribute("weight"));
            ctObj.color = XmlHelper.ReadString(node.Attribute("color"));
            ctObj.opacity = XmlHelper.ReadString(node.Attribute("opacity"));
            if (node.Attribute("linestyle") != null)
            {
                ctObj.linestyle = (ST_StrokeLineStyle)Enum.Parse(typeof(ST_StrokeLineStyle), node.Attribute("linestyle").Value);
                ctObj.linestyleFieldSpecified = true;
            }
            else
            {
                ctObj.linestyleFieldSpecified = false;
            }
            if (node.Attribute("miterlimit") != null)
            {
                ctObj.miterlimit = XmlHelper.ReadDecimal(node.Attribute("miterlimit"));
                ctObj.miterlimitFieldSpecified = true;
            }
            else
            {
                ctObj.miterlimitFieldSpecified = false;
            }
            if (node.Attribute("joinstyle") != null)
            {
                ctObj.joinstyleFieldSpecified = true;
                ctObj.joinstyle = (ST_StrokeJoinStyle)Enum.Parse(typeof(ST_StrokeJoinStyle), node.Attribute("joinstyle").Value);
            }
            else
            {
                ctObj.joinstyleFieldSpecified = false;
            }
            if (node.Attribute("endcap") != null)
            {
                ctObj.endcap = (ST_StrokeEndCap)Enum.Parse(typeof(ST_StrokeEndCap), node.Attribute("endcap").Value);
                ctObj.endcapFieldSpecified = true;
            }
            else
            {
                ctObj.endcapFieldSpecified = false;
            }
            ctObj.dashstyle = XmlHelper.ReadString(node.Attribute("dashstyle"));

            if (node.Attribute("filltype") != null)
            {
                ctObj.filltype = (ST_FillType)Enum.Parse(typeof(ST_FillType), node.Attribute("filltype").Value);
                ctObj.filltypeFieldSpecified = true;
            }
            else
            {
                ctObj.filltypeFieldSpecified = false;
            }
            ctObj.src = XmlHelper.ReadString(node.Attribute("src"));
            if (node.Attribute("imageaspect") != null)
            {
                ctObj.imageaspect = (ST_ImageAspect)Enum.Parse(typeof(ST_ImageAspect), node.Attribute("imageaspect").Value);
                ctObj.imageaspectFieldSpecified = true;
            }
            else
            {
                ctObj.imageaspectFieldSpecified = false;
            }
            ctObj.imagesize = XmlHelper.ReadString(node.Attribute("imagesize"));
            if (node.Attribute("imagealignshape") != null)
            {
                ctObj.imagealignshape = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("imagealignshape"));
                ctObj.imagealignshapeSpecified = true;
            }
            else
            {
                ctObj.imagealignshapeSpecified = false;
            }
            ctObj.color2 = XmlHelper.ReadString(node.Attribute("color2"));
            if (node.Attribute("startarrow") != null)
            {
                ctObj.startarrow = (ST_StrokeArrowType)Enum.Parse(typeof(ST_StrokeArrowType), node.Attribute("startarrow").Value);
                ctObj.startarrowFieldSpecified = true;
            }
            else
            {
                ctObj.startarrowFieldSpecified = false;
            }
            if (node.Attribute("startarrowwidth") != null)
            {
                ctObj.startarrowwidth = (ST_StrokeArrowWidth)Enum.Parse(typeof(ST_StrokeArrowWidth), node.Attribute("startarrowwidth").Value);
                ctObj.startarrowwidthFieldSpecified = true;
            }
            else
            {
                ctObj.startarrowwidthFieldSpecified = false;
            }
            if (node.Attribute("startarrowlength") != null)
            {
                ctObj.startarrowlength = (ST_StrokeArrowLength)Enum.Parse(typeof(ST_StrokeArrowLength), node.Attribute("startarrowlength").Value);
                ctObj.startarrowlengthFieldSpecified = true;
            }
            else
            {
                ctObj.startarrowlengthFieldSpecified = false;
            }
            if (node.Attribute("endarrow") != null)
            {
                ctObj.endarrow = (ST_StrokeArrowType)Enum.Parse(typeof(ST_StrokeArrowType), node.Attribute("endarrow").Value);
                ctObj.endarrowFieldSpecified = true;
            }
            else
            {
                ctObj.endarrowFieldSpecified = false;
            }
            if (node.Attribute("endarrowwidth") != null)
            {
                ctObj.endarrowwidth = (ST_StrokeArrowWidth)Enum.Parse(typeof(ST_StrokeArrowWidth), node.Attribute("endarrowwidth").Value);
                ctObj.endarrowwidthFieldSpecified = true;
            }
            else
            {
                ctObj.endarrowwidthFieldSpecified = false;
            }
            if (node.Attribute("endarrowlength") != null)
            {
                ctObj.endarrowlength = (ST_StrokeArrowLength)Enum.Parse(typeof(ST_StrokeArrowLength), node.Attribute("endarrowlength").Value);
                ctObj.endarrowlengthFieldSpecified = true;
            }
            else
            {
                ctObj.endarrowlengthFieldSpecified = false;
            }
            if (node.Attribute("insetpen") != null)
                ctObj.insetpen = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("insetpen"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
            XmlHelper.WriteAttribute(sw, "weight", this.weight);
            XmlHelper.WriteAttribute(sw, "color", this.color);
            XmlHelper.WriteAttribute(sw, "opacity", this.opacity);
            if(linestyleFieldSpecified)
                XmlHelper.WriteAttribute(sw, "linestyle", this.linestyle.ToString());
            if(miterlimitFieldSpecified)
                XmlHelper.WriteAttribute(sw, "miterlimit", (float)this.miterlimit);
            if(joinstyleFieldSpecified)
                XmlHelper.WriteAttribute(sw, "joinstyle", this.joinstyle.ToString());
            if(endcapFieldSpecified)
                XmlHelper.WriteAttribute(sw, "endcap", this.endcap.ToString());
            XmlHelper.WriteAttribute(sw, "dashstyle", this.dashstyle);
            if(filltypeFieldSpecified)
                XmlHelper.WriteAttribute(sw, "filltype", this.filltype.ToString());
            XmlHelper.WriteAttribute(sw, "src", this.src);
            if(imageaspectFieldSpecified)
                XmlHelper.WriteAttribute(sw, "imageaspect", this.imageaspect.ToString());
            XmlHelper.WriteAttribute(sw, "imagesize", this.imagesize);
            if(imagealignshapeFieldSpecified)
                Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "imagealignshape", this.imagealignshape);
            XmlHelper.WriteAttribute(sw, "color2", this.color2);
            if(startarrowSpecified)
                XmlHelper.WriteAttribute(sw, "startarrow", this.startarrow.ToString());
            if(startarrowwidthFieldSpecified)
                XmlHelper.WriteAttribute(sw, "startarrowwidth", this.startarrowwidth.ToString());
            if(startarrowlengthFieldSpecified)
                XmlHelper.WriteAttribute(sw, "startarrowlength", this.startarrowlength.ToString());
            if(endarrowFieldSpecified)
                XmlHelper.WriteAttribute(sw, "endarrow", this.endarrow.ToString());
            if(endarrowwidthFieldSpecified)
                XmlHelper.WriteAttribute(sw, "endarrowwidth", this.endarrowwidth.ToString());
            if(endarrowlengthFieldSpecified)
                XmlHelper.WriteAttribute(sw, "endarrowlength", this.endarrowlength.ToString());
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "insetpen", this.insetpen);
            sw.Write("/>");
        }

        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse on {
            get {
                return this.onField;
            }
            set {
                this.onField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool onSpecified {
            get {
                return this.onFieldSpecified;
            }
            set {
                this.onFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        
        [XmlAttribute]
        public string color {
            get {
                return this.colorField;
            }
            set {
                this.colorField = value;
            }
        }
        
        
        [XmlAttribute]
        public string opacity {
            get {
                return this.opacityField;
            }
            set {
                this.opacityField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeLineStyle linestyle {
            get {
                return this.linestyleField;
            }
            set {
                this.linestyleField = value;
                this.linestyleFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool linestyleSpecified {
            get {
                return this.linestyleFieldSpecified;
            }
            set {
                this.linestyleFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public decimal miterlimit {
            get {
                return this.miterlimitField;
            }
            set {
                this.miterlimitField = value;
                this.miterlimitFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool miterlimitSpecified {
            get {
                return this.miterlimitFieldSpecified;
            }
            set {
                this.miterlimitFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeJoinStyle joinstyle {
            get {
                return this.joinstyleField;
            }
            set {
                this.joinstyleField = value;
                this.joinstyleFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool joinstyleSpecified {
            get {
                return this.joinstyleFieldSpecified;
            }
            set {
                this.joinstyleFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeEndCap endcap {
            get {
                return this.endcapField;
            }
            set {
                this.endcapField = value;
                this.endcapFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool endcapSpecified {
            get {
                return this.endcapFieldSpecified;
            }
            set {
                this.endcapFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string dashstyle {
            get {
                return this.dashstyleField;
            }
            set {
                this.dashstyleField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_FillType filltype {
            get {
                return this.filltypeField;
            }
            set {
                this.filltypeField = value;
                this.filltypeFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool filltypeSpecified {
            get {
                return this.filltypeFieldSpecified;
            }
            set {
                this.filltypeFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_ImageAspect imageaspect {
            get {
                return this.imageaspectField;
            }
            set {
                this.imageaspectField = value;
                this.imageaspectFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool imageaspectSpecified {
            get {
                return this.imageaspectFieldSpecified;
            }
            set {
                this.imageaspectFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string imagesize {
            get {
                return this.imagesizeField;
            }
            set {
                this.imagesizeField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse imagealignshape {
            get {
                return this.imagealignshapeField;
            }
            set {
                this.imagealignshapeField = value;
                this.imagealignshapeFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool imagealignshapeSpecified {
            get {
                return this.imagealignshapeFieldSpecified;
            }
            set {
                this.imagealignshapeFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string color2 {
            get {
                return this.color2Field;
            }
            set {
                this.color2Field = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeArrowType startarrow {
            get {
                return this.startarrowField;
            }
            set {
                this.startarrowField = value;
                this.startarrowFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool startarrowSpecified {
            get {
                return this.startarrowFieldSpecified;
            }
            set {
                this.startarrowFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeArrowWidth startarrowwidth {
            get {
                return this.startarrowwidthField;
            }
            set {
                this.startarrowwidthField = value;
                this.startarrowwidthFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool startarrowwidthSpecified {
            get {
                return this.startarrowwidthFieldSpecified;
            }
            set {
                this.startarrowwidthFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeArrowLength startarrowlength {
            get {
                return this.startarrowlengthField;
            }
            set {
                this.startarrowlengthField = value;
                this.startarrowlengthFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool startarrowlengthSpecified {
            get {
                return this.startarrowlengthFieldSpecified;
            }
            set {
                this.startarrowlengthFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeArrowType endarrow {
            get {
                return this.endarrowField;
            }
            set {
                this.endarrowField = value;
                this.endarrowFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool endarrowSpecified {
            get {
                return this.endarrowFieldSpecified;
            }
            set {
                this.endarrowFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeArrowWidth endarrowwidth {
            get {
                return this.endarrowwidthField;
            }
            set {
                this.endarrowwidthField = value;
                this.endarrowwidthFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool endarrowwidthSpecified {
            get {
                return this.endarrowwidthFieldSpecified;
            }
            set {
                this.endarrowwidthFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_StrokeArrowLength endarrowlength {
            get {
                return this.endarrowlengthField;
            }
            set {
                this.endarrowlengthField = value;
                this.endarrowlengthFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool endarrowlengthSpecified {
            get {
                return this.endarrowlengthFieldSpecified;
            }
            set {
                this.endarrowlengthFieldSpecified = value;
            }
        }
                
        
        [XmlAttribute]
        public ST_TrueFalse insetpen {
            get {
                return this.insetpenField;
            }
            set {
                this.insetpenField = value;
                this.insetpenFieldSpecified = true;
            }
        }
        
        
        [XmlIgnore]
        public bool insetpenSpecified {
            get {
                return this.insetpenFieldSpecified;
            }
            set {
                this.insetpenFieldSpecified = value;
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_StrokeLineStyle {
        
        
        single,
        
        
        thinThin,
        
        
        thinThick,
        
        
        thickThin,
        
        
        thickBetweenThin,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_StrokeJoinStyle {
        
        
        round,
        
        
        bevel,
        
        
        miter,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_StrokeEndCap {
        
        
        flat,
        
        
        square,
        
        
        round,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_StrokeArrowType {
        
        
        none,
        
        
        block,
        
        
        classic,
        
        
        oval,
        
        
        diamond,
        
        
        open,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_StrokeArrowWidth {
        
        
        narrow,
        
        
        medium,
        
        
        wide,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_StrokeArrowLength {
        
        
        @short,
        
        
        medium,
        
        
        @long,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Textbox {
        
        private string itemField;
        
        private string idField;
        
        private string styleField;
        
        private string insetField;
        
        
        //[XmlAnyElement()]
        public string ItemXml {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }


        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [XmlAttribute]
        public string style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        
        [XmlAttribute]
        public string inset {
            get {
                return this.insetField;
            }
            set {
                this.insetField = value;
            }
        }
        public static CT_Textbox Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Textbox ctObj = new CT_Textbox();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            ctObj.style = XmlHelper.ReadString(node.Attribute("style"));
            ctObj.inset = XmlHelper.ReadString(node.Attribute("inset"));
            ctObj.ItemXml = node.Value;
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "style", this.style);
            XmlHelper.WriteAttribute(sw, "inset", this.inset);
            sw.Write(">");
            if (this.ItemXml != null)
                sw.Write(this.ItemXml);
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_TextPath {
        
        private string idField;
        
        private string styleField;
        
        private ST_TrueFalse onField;
        
        private bool onFieldSpecified;
        
        private ST_TrueFalse fitshapeField;
        
        private bool fitshapeFieldSpecified;
        
        private ST_TrueFalse fitpathField;
        
        private bool fitpathFieldSpecified;
        
        private ST_TrueFalse trimField;
        
        private bool trimFieldSpecified;
        
        private ST_TrueFalse xscaleField;
        
        private bool xscaleFieldSpecified;
        
        private string stringField;

        public static CT_TextPath Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_TextPath ctObj = new CT_TextPath();
            ctObj.id = XmlHelper.ReadString(node.Attribute("id"));
            ctObj.style = XmlHelper.ReadString(node.Attribute("style"));
            if (node.Attribute("on") != null)
                ctObj.on = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("on"));
            if (node.Attribute("fitshape") != null)
                ctObj.fitshape = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("fitshape"));
            if (node.Attribute("fitpath") != null)
                ctObj.fitpath = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("fitpath"));
            if (node.Attribute("trim") != null)
                ctObj.trim = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("trim"));
            if (node.Attribute("xscale") != null)
                ctObj.xscale = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("xscale"));
            ctObj.@string = XmlHelper.ReadString(node.Attribute("string"));
            return ctObj;
        }



        internal void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "style", this.style);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "fitshape", this.fitshape);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "fitpath", this.fitpath);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "trim", this.trim);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "xscale", this.xscale);
            XmlHelper.WriteAttribute(sw, "string", this.@string);
            sw.Write(">");
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [XmlAttribute]
        public string style {
            get {
                return this.styleField;
            }
            set {
                this.styleField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse on {
            get {
                return this.onField;
            }
            set {
                this.onField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool onSpecified {
            get {
                return this.onFieldSpecified;
            }
            set {
                this.onFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse fitshape {
            get {
                return this.fitshapeField;
            }
            set {
                this.fitshapeField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool fitshapeSpecified {
            get {
                return this.fitshapeFieldSpecified;
            }
            set {
                this.fitshapeFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse fitpath {
            get {
                return this.fitpathField;
            }
            set {
                this.fitpathField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool fitpathSpecified {
            get {
                return this.fitpathFieldSpecified;
            }
            set {
                this.fitpathFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse trim {
            get {
                return this.trimField;
            }
            set {
                this.trimField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool trimSpecified {
            get {
                return this.trimFieldSpecified;
            }
            set {
                this.trimFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse xscale {
            get {
                return this.xscaleField;
            }
            set {
                this.xscaleField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool xscaleSpecified {
            get {
                return this.xscaleFieldSpecified;
            }
            set {
                this.xscaleFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string @string {
            get {
                return this.stringField;
            }
            set {
                this.stringField = value;
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:excel:ClientData")]
        ClientData,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:iscomment")]
        iscomment,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:textdata")]
        textdata,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:anchorlock")]
        anchorlock,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderbottom")]
        borderbottom,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderleft")]
        borderleft,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderright")]
        borderright,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:bordertop")]
        bordertop,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:wrap")]
        wrap,
        
        
        fill,
        
        
        formulas,
        
        
        handles,
        
        
        imagedata,
        
        
        path,
        
        
        shadow,
        
        
        stroke,
        
        
        textbox,
        
        
        textpath,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot("shapetype",Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Shapetype {
        
        private CT_Path pathField;
        
        private List<CT_Formulas> formulasField = new List<CT_Formulas>();
        
        private List<CT_Handles> handlesField = new List<CT_Handles>();
        
        private List<CT_Fill> fillField = new List<CT_Fill>();
        
        private CT_Stroke strokeField;
        
        private List<CT_Shadow> shadowField;
        
        private List<CT_Textbox> textboxField;
        
        private List<CT_TextPath> textpathField = new List<CT_TextPath>();
        
        private List<CT_ImageData> imagedataField;
        
        private List<CT_Wrap> wrapField;
        
        private List<CT_AnchorLock> anchorlockField;

        private CT_Lock lockField;
        
        private List<CT_Border> bordertopField;
        
        private List<CT_Border> borderbottomField;
        
        private List<CT_Border> borderleftField;
        
        private List<CT_Border> borderrightField;
        
        private List<CT_ClientData> clientDataField;
        
        private List<CT_Rel> textdataField;
        
        private string adjField;
        private string idField;
        private ST_TrueFalse filledField;
        private ST_TrueFalse strokedField;
        private ST_TrueFalse preferrelativeField;
        //private string styleField;
        private float sptField;
        private string coordsizeField;

        //static XmlSerializer serializer = new XmlSerializer(typeof(CT_Shapetype), "urn:schemas-microsoft-com:vml");

        //public static CT_Shapetype Parse(string xmltext)
        //{
        //    TextReader tr = new StringReader(xmltext);
        //    CT_Shapetype obj = (CT_Shapetype)serializer.Deserialize(tr);
        //    return obj;
        //}

        public static CT_Shapetype Parse(XElement node, XmlNamespaceManager namespaceManager)
        {
            if (node == null)
                return null;
            CT_Shapetype ctObj = new CT_Shapetype();
            if (node.Attribute("stroked") != null)
                ctObj.stroked = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("stroked"));
            if (node.Attribute("filled") != null)
                ctObj.filled = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("filled"));
            if (node.Attribute("o:preferrelative") != null)
                ctObj.preferrelative = Npoi.Core.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attribute("o:preferrelative"));
            ctObj.coordsize = XmlHelper.ReadString(node.Attribute("coordsize"));
            if (node.Attribute("o:spt") != null)
                ctObj.id = XmlHelper.ReadString(node.Attribute("o:spt"));
            ctObj.adj = XmlHelper.ReadString(node.Attribute("adj"));
            ctObj.path2 = XmlHelper.ReadString(node.Attribute("path"));
            ctObj.formulas = new List<CT_Formulas>();
            ctObj.handles = new List<CT_Handles>();
            ctObj.fill = new List<CT_Fill>();
            ctObj.shadow = new List<CT_Shadow>();
            ctObj.textbox = new List<CT_Textbox>();
            ctObj.textpath = new List<CT_TextPath>();
            ctObj.imagedata = new List<CT_ImageData>();
            ctObj.wrap = new List<CT_Wrap>();
            ctObj.anchorlock = new List<CT_AnchorLock>();
            ctObj.bordertop = new List<CT_Border>();
            ctObj.borderbottom = new List<CT_Border>();
            ctObj.borderleft = new List<CT_Border>();
            ctObj.borderright = new List<CT_Border>();
            ctObj.Clientdata = new List<CT_ClientData>();
            ctObj.textdata = new List<CT_Rel>();
            foreach (XElement childNode in node.ChildElements())
            {
                if (childNode.Name.LocalName == "stroke")
                    ctObj.stroke = CT_Stroke.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "path")
                    ctObj.path = CT_Path.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "lock")
                    ctObj.@lock = CT_Lock.Parse(childNode, namespaceManager);
                else if (childNode.Name.LocalName == "formulas")
                    ctObj.formulas.Add(CT_Formulas.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "handles")
                    ctObj.handles.Add(CT_Handles.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "fill")
                    ctObj.fill.Add(CT_Fill.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "shadow")
                    ctObj.shadow.Add(CT_Shadow.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "textbox")
                    ctObj.textbox.Add(CT_Textbox.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "textpath")
                    ctObj.textpath.Add(CT_TextPath.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "imagedata")
                    ctObj.imagedata.Add(CT_ImageData.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "wrap")
                    ctObj.wrap.Add(CT_Wrap.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "anchorlock")
                    ctObj.anchorlock.Add(new CT_AnchorLock());
                else if (childNode.Name.LocalName == "bordertop")
                    ctObj.bordertop.Add(CT_Border.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "borderbottom")
                    ctObj.borderbottom.Add(CT_Border.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "borderleft")
                    ctObj.borderleft.Add(CT_Border.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "borderright")
                    ctObj.borderright.Add(CT_Border.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "ClientData")
                    ctObj.Clientdata.Add(CT_ClientData.Parse(childNode, namespaceManager));
                else if (childNode.Name.LocalName == "textdata")
                    ctObj.textdata.Add(CT_Rel.Parse(childNode, namespaceManager));
            }
            return ctObj;
        }



        public void Write(StreamWriter sw, string nodeName)
        {
            sw.Write(string.Format("<v:{0}", nodeName));
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "stroked", this.stroked, true);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "filled", this.filled, true);
            Npoi.Core.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "o:preferrelative", this.preferrelative);
            XmlHelper.WriteAttribute(sw, "coordsize", this.coordsize);
            XmlHelper.WriteAttribute(sw, "o:spt", this.spt);
            XmlHelper.WriteAttribute(sw, "id", this.id);
            XmlHelper.WriteAttribute(sw, "adj", this.adj);
            XmlHelper.WriteAttribute(sw, "path", this.path2);
            sw.Write(">");
            if (this.stroke != null)
                this.stroke.Write(sw, "stroke");

            if (this.formulas != null)
            {
                foreach (CT_Formulas x in this.formulas)
                {
                    x.Write(sw, "formulas");
                }
            }
            if (this.handles != null)
            {
                foreach (CT_Handles x in this.handles)
                {
                    x.Write(sw, "handles");
                }
            }
            if (this.fill != null)
            {
                foreach (CT_Fill x in this.fill)
                {
                    x.Write(sw, "fill");
                }
            }
            if (this.shadow != null)
            {
                foreach (CT_Shadow x in this.shadow)
                {
                    x.Write(sw, "shadow");
                }
            }
            if (this.path != null)
                this.path.Write(sw, "path");
            if (this.@lock != null)
                this.@lock.Write(sw, "lock");
            if (this.textbox != null)
            {
                foreach (CT_Textbox x in this.textbox)
                {
                    x.Write(sw, "textbox");
                }
            }
            if (this.textpath != null)
            {
                foreach (CT_TextPath x in this.textpath)
                {
                    x.Write(sw, "textpath");
                }
            }
            if (this.imagedata != null)
            {
                foreach (CT_ImageData x in this.imagedata)
                {
                    x.Write(sw, "imagedata");
                }
            }
            if (this.wrap != null)
            {
                foreach (CT_Wrap x in this.wrap)
                {
                    x.Write(sw, "wrap");
                }
            }
            if (this.anchorlock != null)
            {
                foreach (CT_AnchorLock x in this.anchorlock)
                {
                    sw.Write("<anchorlock/>");
                }
            }
            if (this.bordertop != null)
            {
                foreach (CT_Border x in this.bordertop)
                {
                    x.Write(sw, "bordertop");
                }
            }
            if (this.borderbottom != null)
            {
                foreach (CT_Border x in this.borderbottom)
                {
                    x.Write(sw, "borderbottom");
                }
            }
            if (this.borderleft != null)
            {
                foreach (CT_Border x in this.borderleft)
                {
                    x.Write(sw, "borderleft");
                }
            }
            if (this.borderright != null)
            {
                foreach (CT_Border x in this.borderright)
                {
                    x.Write(sw, "borderright");
                }
            }
            if (this.Clientdata != null)
            {
                foreach (CT_ClientData x in this.Clientdata)
                {
                    x.Write(sw, "ClientData");
                }
            }
            if (this.textdata != null)
            {
                foreach (CT_Rel x in this.textdata)
                {
                    x.Write(sw, "textdata");
                }
            }
            sw.Write(string.Format("</v:{0}>", nodeName));
        }

        [XmlAttribute]
        public ST_TrueFalse stroked
        {
            get
            {
                return this.strokedField;
            }
            set
            {
                this.strokedField = value;
            }
        }
        [XmlAttribute]
        public ST_TrueFalse filled
        {
            get
            {
                return this.filledField;
            }
            set
            {
                this.filledField = value;
            }
        }
        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public ST_TrueFalse preferrelative
        {
            get
            {
                return this.preferrelativeField;
            }
            set
            {
                this.preferrelativeField = value;
            }
        }
        [XmlAttribute]
        public string coordsize
        {
            get
            {
                return this.coordsizeField;
            }
            set
            {
                this.coordsizeField = value;
            }
        }

        [XmlAttribute(Namespace = "urn:schemas-microsoft-com:office:office")]
        public float spt
        {
            get
            {
                return this.sptField;
            }
            set
            {
                this.sptField = value;
            }
        }
        private string path1Field;

        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set 
            {
                this.idField = value;
            }
        }


        [XmlElement("stroke")]
        public CT_Stroke stroke
        {
            get
            {
                return this.strokeField;
            }
            set
            {
                this.strokeField = value;
            }
        }


        [XmlElement("formulas")]
        public List<CT_Formulas> formulas
        {
            get
            {
                return this.formulasField;
            }
            set
            {

                    this.formulasField = value;
            }
        }


        [XmlElement("handles")]
        public List<CT_Handles> handles
        {
            get
            {
                return this.handlesField;
            }
            set
            {
                    this.handlesField = value;
            }
        }


        [XmlElement("fill")]
        public List<CT_Fill> fill
        {
            get
            {
                return this.fillField;
            }
            set
            {
                this.fillField = value;
            }
        }




        [XmlElement("shadow")]
        public List<CT_Shadow> shadow
        {
            get
            {
                return this.shadowField;
            }
            set
            {
                this.shadowField = value;
            }
        }


        [XmlElement("textbox")]
        public List<CT_Textbox> textbox
        {
            get
            {
                return this.textboxField;
            }
            set
            {
                this.textboxField = value;
            }
        }


        [XmlElement("textpath")]
        public List<CT_TextPath> textpath
        {
            get
            {
                return this.textpathField;
            }
            set
            {
                this.textpathField = value;
            }
        }


        [XmlElement("imagedata")]
        public List<CT_ImageData> imagedata
        {
            get
            {
                return this.imagedataField;
            }
            set
            {
                this.imagedataField = value;
            }
        }


        [XmlElement("wrap", Namespace = "urn:schemas-microsoft-com:office:word")]
        public List<CT_Wrap> wrap
        {
            get
            {
                return this.wrapField;
            }
            set
            {
                this.wrapField = value;
            }
        }


        [XmlElement("anchorlock", Namespace = "urn:schemas-microsoft-com:office:word")]
        public List<CT_AnchorLock> anchorlock
        {
            get
            {
                return this.anchorlockField;
            }
            set
            {
                this.anchorlockField = value;
            }
        }

        [XmlElement("path")]
        public CT_Path path
        {
            get
            {
                return this.pathField;
            }
            set
            {

                this.pathField = value;
            }
        }

        [XmlElement("lock", Namespace = "urn:schemas-microsoft-com:office:office")]
        public CT_Lock @lock
        {
            get
            {
                return this.lockField;
            }
            set
            {
                    this.lockField = value;
            }
        }

        [XmlElement("bordertop", Namespace = "urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> bordertop
        {
            get
            {
                return this.bordertopField;
            }
            set
            {
                this.bordertopField = value;
            }
        }


        [XmlElement("borderbottom", Namespace = "urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderbottom
        {
            get
            {
                return this.borderbottomField;
            }
            set
            {
                this.borderbottomField = value;
            }
        }


        [XmlElement("borderleft", Namespace = "urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderleft
        {
            get
            {
                return this.borderleftField;
            }
            set
            {
                this.borderleftField = value;
            }
        }


        [XmlElement("borderright", Namespace = "urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderright
        {
            get
            {
                return this.borderrightField;
            }
            set
            {
                this.borderrightField = value;
            }
        }
        
        
        [XmlElement("clientdata", Namespace="urn:schemas-microsoft-com:office:excel")]
        public List<CT_ClientData> Clientdata {
            get {
                return this.clientDataField;
            }
            set {
                this.clientDataField = value;
            }
        }


        [XmlElement("textdata", Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
        public List<CT_Rel> textdata
        {
            get
            {
                return this.textdataField;
            }
            set
            {
                this.textdataField = value;
            }
        }
        
        
        [XmlAttribute]
        public string adj {
            get {
                return this.adjField;
            }
            set {
                this.adjField = value;
            }
        }
        
        
        [XmlAttribute("path")]
        public string path2 {
            get {
                return this.path1Field;
            }
            set {
                this.path1Field = value;
            }
        }

        public CT_Stroke AddNewStroke()
        {
            this.strokeField = new CT_Stroke();
            return strokeField;
        }
        public CT_Path AddNewPath()
        {
                this.pathField = new CT_Path();
            return this.pathField;
        }
        //internal static XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces(new XmlQualifiedName[] {
        //    new XmlQualifiedName("o", "urn:schemas-microsoft-com:office:office"),
        //    new XmlQualifiedName("x", "urn:schemas-microsoft-com:office:excel"),
        //    new XmlQualifiedName("v", "urn:schemas-microsoft-com:vml")
        //});

        //public override string ToString()
        //{
        //    using (StringWriter stringWriter = new StringWriter())
        //    {
        //        XmlWriterSettings settings = new XmlWriterSettings();
        //        settings.Encoding = Encoding.UTF8;
        //        settings.OmitXmlDeclaration = true;

        //        using (XmlWriter writer = XmlWriter.Create(stringWriter, settings))
        //        {
        //            serializer.Serialize(writer, this, namespaces);
        //        }
        //        return stringWriter.ToString();
        //    }
        //}

        public CT_Formulas AddNewFormulas()
        {
            if (this.formulasField == null)
                this.formulasField = new List<CT_Formulas>();
            CT_Formulas obj = new CT_Formulas();
            this.formulasField.Add(obj);
            return obj;
        }

        public CT_TextPath AddNewTextpath()
        {
            if (this.textpathField == null)
                this.textpathField = new List<CT_TextPath>();
            CT_TextPath obj = new CT_TextPath();
            this.textpathField.Add(obj);
            return obj;
        }

        public CT_Handles AddNewHandles()
        {
            if (this.handlesField == null)
                this.handlesField = new List<CT_Handles>();
            CT_Handles obj = new CT_Handles();
            this.handlesField.Add(obj);
            return obj;
        }

        public CT_Lock AddNewLock()
        {
            CT_Lock lockField = new CT_Lock();
            return lockField;
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Group {
        
        private List<object> itemsField = new List<object>();
        
        private List<ItemsChoiceType6> itemsElementNameField = new List<ItemsChoiceType6>();
        
        private ST_TrueFalse filledField;
        
        private bool filledFieldSpecified;
        
        private string fillcolorField;
        
        private ST_EditAs editasField;
        
        private bool editasFieldSpecified;
        
        
        [XmlElement("ClientData", typeof(CT_ClientData), Namespace="urn:schemas-microsoft-com:office:excel")]
        [XmlElement("textdata", typeof(CT_Rel), Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        [XmlElement("anchorlock", typeof(CT_AnchorLock), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderbottom", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderleft", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderright", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("bordertop", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("wrap", typeof(CT_Wrap), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("arc", typeof(CT_Arc))]
        [XmlElement("curve", typeof(CT_Curve))]
        [XmlElement("fill", typeof(CT_Fill))]
        [XmlElement("formulas", typeof(CT_Formulas))]
        [XmlElement("group", typeof(CT_Group))]
        [XmlElement("handles", typeof(CT_Handles))]
        [XmlElement("image", typeof(CT_Image))]
        [XmlElement("imagedata", typeof(CT_ImageData))]
        [XmlElement("line", typeof(CT_Line))]
        [XmlElement("oval", typeof(CT_Oval))]
        [XmlElement("path", typeof(CT_Path))]
        [XmlElement("polyline", typeof(CT_PolyLine))]
        [XmlElement("rect", typeof(CT_Rect))]
        [XmlElement("roundrect", typeof(CT_RoundRect))]
        [XmlElement("shadow", typeof(CT_Shadow))]
        [XmlElement("shape", typeof(CT_Shape))]
        [XmlElement("shapetype", typeof(CT_Shapetype))]
        [XmlElement("stroke", typeof(CT_Stroke))]
        [XmlElement("textbox", typeof(CT_Textbox))]
        [XmlElement("textpath", typeof(CT_TextPath))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items {
            get {
                if (this.itemsField == null)
                    return null;
                return this.itemsField.ToArray();
            }
            set {
                if (value == null)
                    this.itemsField = new List<object>();
                else
                    this.itemsField = new List<object>(value);
            }
        }
        
        
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType6[] ItemsElementName {
            get {
                return this.itemsElementNameField.ToArray();
            }
            set {
                if (value == null)
                    this.itemsElementNameField = new List<ItemsChoiceType6>();
                else
                    this.itemsElementNameField = new List<ItemsChoiceType6>(value);
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse filled {
            get {
                return this.filledField;
            }
            set {
                this.filledField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool filledSpecified {
            get {
                return this.filledFieldSpecified;
            }
            set {
                this.filledFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string fillcolor {
            get {
                return this.fillcolorField;
            }
            set {
                this.fillcolorField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_EditAs editas {
            get {
                return this.editasField;
            }
            set {
                this.editasField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool editasSpecified {
            get {
                return this.editasFieldSpecified;
            }
            set {
                this.editasFieldSpecified = value;
            }
        }

        public CT_Shapetype AddNewShapetype()
        {
            return AddNewObject<CT_Shapetype>(ItemsChoiceType6.shapetype);
        }
        #region Generic methods for object operation

        private List<T> GetObjectList<T>(ItemsChoiceType6 type) where T : class
        {
            lock (this)
            {
                List<T> list = new List<T>();
                for (int i = 0; i < itemsElementNameField.Count; i++)
                {
                    if (itemsElementNameField[i] == type)
                        list.Add(itemsField[i] as T);
                }
                return list;
            }
        }
        private int SizeOfObjectArray(ItemsChoiceType6 type)
        {
            lock (this)
            {
                int size = 0;
                for (int i = 0; i < itemsElementNameField.Count; i++)
                {
                    if (itemsElementNameField[i] == type)
                        size++;
                }
                return size;
            }
        }
        private T GetObjectArray<T>(int p, ItemsChoiceType6 type) where T : class
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return null;
                return itemsField[pos] as T;
            }
        }
        private T InsertNewObject<T>(ItemsChoiceType6 type, int p) where T : class, new()
        {
            T t = new T();
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                this.itemsElementNameField.Insert(pos, type);
                this.itemsField.Insert(pos, t);
            }
            return t;
        }
        private T AddNewObject<T>(ItemsChoiceType6 type) where T : class, new()
        {
            T t = new T();
            lock (this)
            {
                this.itemsElementNameField.Add(type);
                this.itemsField.Add(t);
            }
            return t;
        }
        private void SetObjectArray<T>(ItemsChoiceType6 type, int p, T obj) where T : class
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return;
                if (this.itemsField[pos] is T)
                    this.itemsField[pos] = obj;
                else
                    throw new Exception(string.Format(@"object types are difference, itemsField[{0}] is {1}, and parameter obj is {2}",
                        pos, this.itemsField[pos].GetType().Name, typeof(T).Name));
            }
        }
        private int GetObjectIndex(ItemsChoiceType6 type, int p)
        {
            int index = -1;
            int pos = 0;
            for (int i = 0; i < itemsElementNameField.Count; i++)
            {
                if (itemsElementNameField[i] == type)
                {
                    if (pos == p)
                    {
                        //return itemsField[p] as T;
                        index = i;
                        break;
                    }
                    else
                        pos++;
                }
            }
            return index;
        }
        private void RemoveObject(ItemsChoiceType6 type, int p)
        {
            lock (this)
            {
                int pos = GetObjectIndex(type, p);
                if (pos < 0 || pos >= this.itemsField.Count)
                    return;
                itemsElementNameField.RemoveAt(pos);
                itemsField.RemoveAt(pos);
            }
        }
        #endregion

        public CT_Shape AddNewShape()
        {
            return AddNewObject<CT_Shape>(ItemsChoiceType6.shape);
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Arc {
        
        private List<CT_Path> pathField;
        
        private List<CT_Formulas> formulasField;
        
        private List<CT_Handles> handlesField;
        
        private List<CT_Fill> fillField;
        
        private List<CT_Stroke> strokeField;
        
        private List<CT_Shadow> shadowField;
        
        private List<CT_Textbox> textboxField;
        
        private List<CT_TextPath> textpathField;
        
        private List<CT_ImageData> imagedataField;
        
        private List<CT_Wrap> wrapField;
        
        private List<CT_AnchorLock> anchorlockField;
        
        private List<CT_Border> bordertopField;
        
        private List<CT_Border> borderbottomField;
        
        private List<CT_Border> borderleftField;
        
        private List<CT_Border> borderrightField;
        
        private List<CT_ClientData> clientDataField;
        
        private List<CT_Rel> textdataField;
        
        private decimal startAngleField;
        
        private bool startAngleFieldSpecified;
        
        private decimal endAngleField;
        
        private bool endAngleFieldSpecified;
        
        
        [XmlElement("path")]
        public List<CT_Path> path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        
        [XmlElement("formulas")]
        public List<CT_Formulas> formulas {
            get {
                return this.formulasField;
            }
            set {
                this.formulasField = value;
            }
        }
        
        
        [XmlElement("handles")]
        public List<CT_Handles> handles {
            get {
                return this.handlesField;
            }
            set {
                this.handlesField = value;
            }
        }
        
        
        [XmlElement("fill")]
        public List<CT_Fill> fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
        
        
        [XmlElement("stroke")]
        public List<CT_Stroke> stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
            }
        }
        
        
        [XmlElement("shadow")]
        public List<CT_Shadow> shadow {
            get {
                return this.shadowField;
            }
            set {
                this.shadowField = value;
            }
        }
        
        
        [XmlElement("textbox")]
        public List<CT_Textbox> textbox {
            get {
                return this.textboxField;
            }
            set {
                this.textboxField = value;
            }
        }
        
        
        [XmlElement("textpath")]
        public List<CT_TextPath> textpath {
            get {
                return this.textpathField;
            }
            set {
                this.textpathField = value;
            }
        }
        
        
        [XmlElement("imagedata")]
        public List<CT_ImageData> imagedata {
            get {
                return this.imagedataField;
            }
            set {
                this.imagedataField = value;
            }
        }
        
        
        [XmlElement("wrap", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Wrap> wrap {
            get {
                return this.wrapField;
            }
            set {
                this.wrapField = value;
            }
        }
        
        
        [XmlElement("anchorlock", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_AnchorLock> anchorlock {
            get {
                return this.anchorlockField;
            }
            set {
                this.anchorlockField = value;
            }
        }
        
        
        [XmlElement("bordertop", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> bordertop {
            get {
                return this.bordertopField;
            }
            set {
                this.bordertopField = value;
            }
        }
        
        
        [XmlElement("borderbottom", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderbottom {
            get {
                return this.borderbottomField;
            }
            set {
                this.borderbottomField = value;
            }
        }
        
        
        [XmlElement("borderleft", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderleft {
            get {
                return this.borderleftField;
            }
            set {
                this.borderleftField = value;
            }
        }
        
        
        [XmlElement("borderright", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderright {
            get {
                return this.borderrightField;
            }
            set {
                this.borderrightField = value;
            }
        }
        
        
        [XmlElement("ClientData", Namespace="urn:schemas-microsoft-com:office:excel")]
        public List<CT_ClientData> ClientData {
            get {
                return this.clientDataField;
            }
            set {
                this.clientDataField = value;
            }
        }
        
        
        [XmlElement("textdata", Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        public List<CT_Rel> textdata {
            get {
                return this.textdataField;
            }
            set {
                this.textdataField = value;
            }
        }
        
        
        [XmlAttribute]
        public decimal startAngle {
            get {
                return this.startAngleField;
            }
            set {
                this.startAngleField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool startAngleSpecified {
            get {
                return this.startAngleFieldSpecified;
            }
            set {
                this.startAngleFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public decimal endAngle {
            get {
                return this.endAngleField;
            }
            set {
                this.endAngleField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool endAngleSpecified {
            get {
                return this.endAngleFieldSpecified;
            }
            set {
                this.endAngleFieldSpecified = value;
            }
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Curve {
        
        private List<CT_Path> pathField;
        
        private List<CT_Formulas> formulasField;
        
        private List<CT_Handles> handlesField;
        
        private List<CT_Fill> fillField;
        
        private List<CT_Stroke> strokeField;
        
        private List<CT_Shadow> shadowField;
        
        private List<CT_Textbox> textboxField;
        
        private List<CT_TextPath> textpathField;
        
        private List<CT_ImageData> imagedataField;
        
        private List<CT_Wrap> wrapField;
        
        private List<CT_AnchorLock> anchorlockField;
        
        private List<CT_Border> bordertopField;
        
        private List<CT_Border> borderbottomField;
        
        private List<CT_Border> borderleftField;
        
        private List<CT_Border> borderrightField;
        
        private List<CT_ClientData> clientDataField;
        
        private List<CT_Rel> textdataField;
        
        private string fromField;
        
        private string control1Field;
        
        private string control2Field;
        
        private string toField;
        
        
        [XmlElement("path")]
        public List<CT_Path> path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        
        [XmlElement("formulas")]
        public List<CT_Formulas> formulas {
            get {
                return this.formulasField;
            }
            set {
                this.formulasField = value;
            }
        }
        
        
        [XmlElement("handles")]
        public List<CT_Handles> handles {
            get {
                return this.handlesField;
            }
            set {
                this.handlesField = value;
            }
        }
        
        
        [XmlElement("fill")]
        public List<CT_Fill> fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
        
        
        [XmlElement("stroke")]
        public List<CT_Stroke> stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
            }
        }
        
        
        [XmlElement("shadow")]
        public List<CT_Shadow> shadow {
            get {
                return this.shadowField;
            }
            set {
                this.shadowField = value;
            }
        }
        
        
        [XmlElement("textbox")]
        public List<CT_Textbox> textbox {
            get {
                return this.textboxField;
            }
            set {
                this.textboxField = value;
            }
        }
        
        
        [XmlElement("textpath")]
        public List<CT_TextPath> textpath {
            get {
                return this.textpathField;
            }
            set {
                this.textpathField = value;
            }
        }
        
        
        [XmlElement("imagedata")]
        public List<CT_ImageData> imagedata {
            get {
                return this.imagedataField;
            }
            set {
                this.imagedataField = value;
            }
        }
        
        
        [XmlElement("wrap", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Wrap> wrap {
            get {
                return this.wrapField;
            }
            set {
                this.wrapField = value;
            }
        }
        
        
        [XmlElement("anchorlock", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_AnchorLock> anchorlock {
            get {
                return this.anchorlockField;
            }
            set {
                this.anchorlockField = value;
            }
        }
        
        
        [XmlElement("bordertop", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> bordertop {
            get {
                return this.bordertopField;
            }
            set {
                this.bordertopField = value;
            }
        }
        
        
        [XmlElement("borderbottom", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderbottom {
            get {
                return this.borderbottomField;
            }
            set {
                this.borderbottomField = value;
            }
        }
        
        
        [XmlElement("borderleft", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderleft {
            get {
                return this.borderleftField;
            }
            set {
                this.borderleftField = value;
            }
        }
        
        
        [XmlElement("borderright", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderright {
            get {
                return this.borderrightField;
            }
            set {
                this.borderrightField = value;
            }
        }
        
        
        [XmlElement("ClientData", Namespace="urn:schemas-microsoft-com:office:excel")]
        public List<CT_ClientData> ClientData {
            get {
                return this.clientDataField;
            }
            set {
                this.clientDataField = value;
            }
        }
        
        
        [XmlElement("textdata", Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        public List<CT_Rel> textdata {
            get {
                return this.textdataField;
            }
            set {
                this.textdataField = value;
            }
        }
        
        
        [XmlAttribute]
        public string from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        
        [XmlAttribute]
        public string control1 {
            get {
                return this.control1Field;
            }
            set {
                this.control1Field = value;
            }
        }
        
        
        [XmlAttribute]
        public string control2 {
            get {
                return this.control2Field;
            }
            set {
                this.control2Field = value;
            }
        }
        
        
        [XmlAttribute]
        public string to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Image {
        
        private List<CT_Path> pathField;
        
        private List<CT_Formulas> formulasField;
        
        private List<CT_Handles> handlesField;
        
        private List<CT_Fill> fillField;
        
        private List<CT_Stroke> strokeField;
        
        private List<CT_Shadow> shadowField;
        
        private List<CT_Textbox> textboxField;
        
        private List<CT_TextPath> textpathField;
        
        private List<CT_ImageData> imagedataField;
        
        private List<CT_Wrap> wrapField;
        
        private List<CT_AnchorLock> anchorlockField;
        
        private List<CT_Border> bordertopField;
        
        private List<CT_Border> borderbottomField;
        
        private List<CT_Border> borderleftField;
        
        private List<CT_Border> borderrightField;
        
        private List<CT_ClientData> clientDataField;
        
        private List<CT_Rel> textdataField;
        
        private string srcField;
        
        private string cropleftField;
        
        private string croptopField;
        
        private string croprightField;
        
        private string cropbottomField;
        
        private string gainField;
        
        private string blacklevelField;
        
        private string gammaField;
        
        private ST_TrueFalse grayscaleField;
        
        private bool grayscaleFieldSpecified;
        
        private ST_TrueFalse bilevelField;
        
        private bool bilevelFieldSpecified;
        
        
        [XmlElement("path")]
        public List<CT_Path> path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        
        [XmlElement("formulas")]
        public List<CT_Formulas> formulas {
            get {
                return this.formulasField;
            }
            set {
                this.formulasField = value;
            }
        }
        
        
        [XmlElement("handles")]
        public List<CT_Handles> handles {
            get {
                return this.handlesField;
            }
            set {
                this.handlesField = value;
            }
        }
        
        
        [XmlElement("fill")]
        public List<CT_Fill> fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
        
        
        [XmlElement("stroke")]
        public List<CT_Stroke> stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
            }
        }
        
        
        [XmlElement("shadow")]
        public List<CT_Shadow> shadow {
            get {
                return this.shadowField;
            }
            set {
                this.shadowField = value;
            }
        }
        
        
        [XmlElement("textbox")]
        public List<CT_Textbox> textbox {
            get {
                return this.textboxField;
            }
            set {
                this.textboxField = value;
            }
        }
        
        
        [XmlElement("textpath")]
        public List<CT_TextPath> textpath {
            get {
                return this.textpathField;
            }
            set {
                this.textpathField = value;
            }
        }
        
        
        [XmlElement("imagedata")]
        public List<CT_ImageData> imagedata {
            get {
                return this.imagedataField;
            }
            set {
                this.imagedataField = value;
            }
        }
        
        
        [XmlElement("wrap", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Wrap> wrap {
            get {
                return this.wrapField;
            }
            set {
                this.wrapField = value;
            }
        }
        
        
        [XmlElement("anchorlock", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_AnchorLock> anchorlock {
            get {
                return this.anchorlockField;
            }
            set {
                this.anchorlockField = value;
            }
        }
        
        
        [XmlElement("bordertop", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> bordertop {
            get {
                return this.bordertopField;
            }
            set {
                this.bordertopField = value;
            }
        }
        
        
        [XmlElement("borderbottom", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderbottom {
            get {
                return this.borderbottomField;
            }
            set {
                this.borderbottomField = value;
            }
        }
        
        
        [XmlElement("borderleft", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderleft {
            get {
                return this.borderleftField;
            }
            set {
                this.borderleftField = value;
            }
        }
        
        
        [XmlElement("borderright", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderright {
            get {
                return this.borderrightField;
            }
            set {
                this.borderrightField = value;
            }
        }
        
        
        [XmlElement("ClientData", Namespace="urn:schemas-microsoft-com:office:excel")]
        public List<CT_ClientData> ClientData {
            get {
                return this.clientDataField;
            }
            set {
                this.clientDataField = value;
            }
        }
        
        
        [XmlElement("textdata", Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        public List<CT_Rel> textdata {
            get {
                return this.textdataField;
            }
            set {
                this.textdataField = value;
            }
        }
        
        
        [XmlAttribute]
        public string src {
            get {
                return this.srcField;
            }
            set {
                this.srcField = value;
            }
        }
        
        
        [XmlAttribute]
        public string cropleft {
            get {
                return this.cropleftField;
            }
            set {
                this.cropleftField = value;
            }
        }
        
        
        [XmlAttribute]
        public string croptop {
            get {
                return this.croptopField;
            }
            set {
                this.croptopField = value;
            }
        }
        
        
        [XmlAttribute]
        public string cropright {
            get {
                return this.croprightField;
            }
            set {
                this.croprightField = value;
            }
        }
        
        
        [XmlAttribute]
        public string cropbottom {
            get {
                return this.cropbottomField;
            }
            set {
                this.cropbottomField = value;
            }
        }
        
        
        [XmlAttribute]
        public string gain {
            get {
                return this.gainField;
            }
            set {
                this.gainField = value;
            }
        }
        
        
        [XmlAttribute]
        public string blacklevel {
            get {
                return this.blacklevelField;
            }
            set {
                this.blacklevelField = value;
            }
        }
        
        
        [XmlAttribute]
        public string gamma {
            get {
                return this.gammaField;
            }
            set {
                this.gammaField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse grayscale {
            get {
                return this.grayscaleField;
            }
            set {
                this.grayscaleField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool grayscaleSpecified {
            get {
                return this.grayscaleFieldSpecified;
            }
            set {
                this.grayscaleFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse bilevel {
            get {
                return this.bilevelField;
            }
            set {
                this.bilevelField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool bilevelSpecified {
            get {
                return this.bilevelFieldSpecified;
            }
            set {
                this.bilevelFieldSpecified = value;
            }
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Line {
        
        private List<CT_Path> pathField;
        
        private List<CT_Formulas> formulasField;
        
        private List<CT_Handles> handlesField;
        
        private List<CT_Fill> fillField;
        
        private List<CT_Stroke> strokeField;
        
        private List<CT_Shadow> shadowField;
        
        private List<CT_Textbox> textboxField;
        
        private List<CT_TextPath> textpathField;
        
        private List<CT_ImageData> imagedataField;
        
        private List<CT_Wrap> wrapField;
        
        private List<CT_AnchorLock> anchorlockField;
        
        private List<CT_Border> bordertopField;
        
        private List<CT_Border> borderbottomField;
        
        private List<CT_Border> borderleftField;
        
        private List<CT_Border> borderrightField;
        
        private List<CT_ClientData> clientDataField;
        
        private List<CT_Rel> textdataField;
        
        private string fromField;
        
        private string toField;
        
        
        [XmlElement("path")]
        public List<CT_Path> path {
            get {
                return this.pathField;
            }
            set {
                this.pathField = value;
            }
        }
        
        
        [XmlElement("formulas")]
        public List<CT_Formulas> formulas {
            get {
                return this.formulasField;
            }
            set {
                this.formulasField = value;
            }
        }
        
        
        [XmlElement("handles")]
        public List<CT_Handles> handles {
            get {
                return this.handlesField;
            }
            set {
                this.handlesField = value;
            }
        }
        
        
        [XmlElement("fill")]
        public List<CT_Fill> fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }
        
        
        [XmlElement("stroke")]
        public List<CT_Stroke> stroke {
            get {
                return this.strokeField;
            }
            set {
                this.strokeField = value;
            }
        }
        
        
        [XmlElement("shadow")]
        public List<CT_Shadow> shadow {
            get {
                return this.shadowField;
            }
            set {
                this.shadowField = value;
            }
        }
        
        
        [XmlElement("textbox")]
        public List<CT_Textbox> textbox {
            get {
                return this.textboxField;
            }
            set {
                this.textboxField = value;
            }
        }
        
        
        [XmlElement("textpath")]
        public List<CT_TextPath> textpath {
            get {
                return this.textpathField;
            }
            set {
                this.textpathField = value;
            }
        }
        
        
        [XmlElement("imagedata")]
        public List<CT_ImageData> imagedata {
            get {
                return this.imagedataField;
            }
            set {
                this.imagedataField = value;
            }
        }
        
        
        [XmlElement("wrap", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Wrap> wrap {
            get {
                return this.wrapField;
            }
            set {
                this.wrapField = value;
            }
        }
        
        
        [XmlElement("anchorlock", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_AnchorLock> anchorlock {
            get {
                return this.anchorlockField;
            }
            set {
                this.anchorlockField = value;
            }
        }
        
        
        [XmlElement("bordertop", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> bordertop {
            get {
                return this.bordertopField;
            }
            set {
                this.bordertopField = value;
            }
        }
        
        
        [XmlElement("borderbottom", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderbottom {
            get {
                return this.borderbottomField;
            }
            set {
                this.borderbottomField = value;
            }
        }
        
        
        [XmlElement("borderleft", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderleft {
            get {
                return this.borderleftField;
            }
            set {
                this.borderleftField = value;
            }
        }
        
        
        [XmlElement("borderright", Namespace="urn:schemas-microsoft-com:office:word")]
        public List<CT_Border> borderright {
            get {
                return this.borderrightField;
            }
            set {
                this.borderrightField = value;
            }
        }
        
        
        [XmlElement("ClientData", Namespace="urn:schemas-microsoft-com:office:excel")]
        public List<CT_ClientData> ClientData {
            get {
                return this.clientDataField;
            }
            set {
                this.clientDataField = value;
            }
        }
        
        
        [XmlElement("textdata", Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        public List<CT_Rel> textdata {
            get {
                return this.textdataField;
            }
            set {
                this.textdataField = value;
            }
        }
        
        
        [XmlAttribute]
        public string from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
            }
        }
        
        
        [XmlAttribute]
        public string to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Oval {
        
        private List<object> itemsField = new List<object>();
        
        private List<ItemsChoiceType2> itemsElementNameField = new List<ItemsChoiceType2>();


        [XmlElement("ClientData", typeof(CT_ClientData), Namespace = "urn:schemas-microsoft-com:office:excel")]
        [XmlElement("textdata", typeof(CT_Rel), Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
        [XmlElement("anchorlock", typeof(CT_AnchorLock), Namespace = "urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderbottom", typeof(CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderleft", typeof(CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderright", typeof(CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
        [XmlElement("bordertop", typeof(CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
        [XmlElement("wrap", typeof(CT_Wrap), Namespace = "urn:schemas-microsoft-com:office:word")]
        [XmlElement("fill", typeof(CT_Fill))]
        [XmlElement("formulas", typeof(CT_Formulas))]
        [XmlElement("handles", typeof(CT_Handles))]
        [XmlElement("imagedata", typeof(CT_ImageData))]
        [XmlElement("path", typeof(CT_Path))]
        [XmlElement("shadow", typeof(CT_Shadow))]
        [XmlElement("stroke", typeof(CT_Stroke))]
        [XmlElement("textbox", typeof(CT_Textbox))]
        [XmlElement("textpath", typeof(CT_TextPath))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField.ToArray();
            }
            set
            {
                if (value == null)
                    this.itemsField = new List<object>();
                else
                    this.itemsField = new List<object>(value);
            }
        }
        
        
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField.ToArray();
            }
            set {
                if (value == null)
                    this.itemsElementNameField = new List<ItemsChoiceType2>();
                else
                    this.itemsElementNameField = new List<ItemsChoiceType2>(value);
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml", IncludeInSchema=false)]
    public enum ItemsChoiceType2 {
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:excel:ClientData")]
        ClientData,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:textdata")]
        textdata,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:anchorlock")]
        anchorlock,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderbottom")]
        borderbottom,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderleft")]
        borderleft,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderright")]
        borderright,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:bordertop")]
        bordertop,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:wrap")]
        wrap,
        
        
        fill,
        
        
        formulas,
        
        
        handles,
        
        
        imagedata,
        
        
        path,
        
        
        shadow,
        
        
        stroke,
        
        
        textbox,
        
        
        textpath,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_PolyLine {
        
        private List<object> itemsField = new List<object>();

        private List<ItemsChoiceType3> itemsElementNameField = new List<ItemsChoiceType3>();
        
        private string pointsField;
        
        
        [XmlElement("ClientData", typeof(CT_ClientData), Namespace="urn:schemas-microsoft-com:office:excel")]
        [XmlElement("textdata", typeof(CT_Rel), Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        [XmlElement("anchorlock", typeof(CT_AnchorLock), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderbottom", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderleft", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("borderright", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("bordertop", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("wrap", typeof(CT_Wrap), Namespace="urn:schemas-microsoft-com:office:word")]
        [XmlElement("fill", typeof(CT_Fill))]
        [XmlElement("formulas", typeof(CT_Formulas))]
        [XmlElement("handles", typeof(CT_Handles))]
        [XmlElement("imagedata", typeof(CT_ImageData))]
        [XmlElement("path", typeof(CT_Path))]
        [XmlElement("shadow", typeof(CT_Shadow))]
        [XmlElement("stroke", typeof(CT_Stroke))]
        [XmlElement("textbox", typeof(CT_Textbox))]
        [XmlElement("textpath", typeof(CT_TextPath))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField.ToArray();
            }
            set {
                if (value == null)
                    this.itemsField = new List<object>();
                else
                    this.itemsField = new List<object>(value);
            }
        }
        
        
        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType3[] ItemsElementName {
            get {
                return this.itemsElementNameField.ToArray();
            }
            set {
                if (value == null)
                    this.itemsElementNameField = new List<ItemsChoiceType3>();
                else
                    this.itemsElementNameField = new List<ItemsChoiceType3>(value);
            }
        }
        
        
        [XmlAttribute]
        public string points {
            get {
                return this.pointsField;
            }
            set {
                this.pointsField = value;
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml", IncludeInSchema=false)]
    public enum ItemsChoiceType3 {
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:excel:ClientData")]
        ClientData,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:textdata")]
        textdata,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:anchorlock")]
        anchorlock,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderbottom")]
        borderbottom,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderleft")]
        borderleft,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderright")]
        borderright,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:bordertop")]
        bordertop,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:wrap")]
        wrap,
        
        
        fill,
        
        
        formulas,
        
        
        handles,
        
        
        imagedata,
        
        
        path,
        
        
        shadow,
        
        
        stroke,
        
        
        textbox,
        
        
        textpath,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Rect {
        
        //private List<object> itemsField;
        
        //private ItemsChoiceType4[] itemsElementNameField;
        
        
        //[XmlElement("ClientData", typeof(CT_ClientData), Namespace="urn:schemas-microsoft-com:office:excel")]
        //[XmlElement("textdata", typeof(CT_Rel), Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        //[XmlElement("anchorlock", typeof(CT_AnchorLock), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("borderbottom", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("borderleft", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("borderright", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("bordertop", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("wrap", typeof(CT_Wrap), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("fill", typeof(CT_Fill))]
        //[XmlElement("formulas", typeof(CT_Formulas))]
        //[XmlElement("handles", typeof(CT_Handles))]
        //[XmlElement("imagedata", typeof(CT_ImageData))]
        //[XmlElement("path", typeof(CT_Path))]
        //[XmlElement("shadow", typeof(CT_Shadow))]
        //[XmlElement("stroke", typeof(CT_Stroke))]
        //[XmlElement("textbox", typeof(CT_Textbox))]
        //[XmlElement("textpath", typeof(CT_TextPath))]
        //[XmlChoiceIdentifier("ItemsElementName")]
        //public List<object> Items {
        //    get {
        //        return this.itemsField;
        //    }
        //    set {
        //        this.itemsField = value;
        //    }
        //}
        
        
        //[XmlElement("ItemsElementName")]
        //[XmlIgnore]
        //public ItemsChoiceType4[] ItemsElementName {
        //    get {
        //        return this.itemsElementNameField;
        //    }
        //    set {
        //        this.itemsElementNameField = value;
        //    }
        //}
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml", IncludeInSchema=false)]
    public enum ItemsChoiceType4 {
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:excel:ClientData")]
        ClientData,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:textdata")]
        textdata,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:anchorlock")]
        anchorlock,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderbottom")]
        borderbottom,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderleft")]
        borderleft,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderright")]
        borderright,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:bordertop")]
        bordertop,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:wrap")]
        wrap,
        
        
        fill,
        
        
        formulas,
        
        
        handles,
        
        
        imagedata,
        
        
        path,
        
        
        shadow,
        
        
        stroke,
        
        
        textbox,
        
        
        textpath,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_RoundRect {
        
        //private List<object> itemsField;
        
        //private ItemsChoiceType5[] itemsElementNameField;
        
        private string arcsizeField;
        
        
        //[XmlElement("ClientData", typeof(CT_ClientData), Namespace="urn:schemas-microsoft-com:office:excel")]
        //[XmlElement("textdata", typeof(CT_Rel), Namespace="urn:schemas-microsoft-com:office:powerpoint")]
        //[XmlElement("anchorlock", typeof(CT_AnchorLock), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("borderbottom", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("borderleft", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("borderright", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("bordertop", typeof(CT_Border), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("wrap", typeof(CT_Wrap), Namespace="urn:schemas-microsoft-com:office:word")]
        //[XmlElement("fill", typeof(CT_Fill))]
        //[XmlElement("formulas", typeof(CT_Formulas))]
        //[XmlElement("handles", typeof(CT_Handles))]
        //[XmlElement("imagedata", typeof(CT_ImageData))]
        //[XmlElement("path", typeof(CT_Path))]
        //[XmlElement("shadow", typeof(CT_Shadow))]
        //[XmlElement("stroke", typeof(CT_Stroke))]
        //[XmlElement("textbox", typeof(CT_Textbox))]
        //[XmlElement("textpath", typeof(CT_TextPath))]
        //[XmlChoiceIdentifier("ItemsElementName")]
        //public List<object> Items {
        //    get {
        //        return this.itemsField;
        //    }
        //    set {
        //        this.itemsField = value;
        //    }
        //}
        
        
        //[XmlElement("ItemsElementName")]
        //[XmlIgnore]
        //public ItemsChoiceType5[] ItemsElementName {
        //    get {
        //        return this.itemsElementNameField;
        //    }
        //    set {
        //        this.itemsElementNameField = value;
        //    }
        //}
        
        
        [XmlAttribute]
        public string arcsize {
            get {
                return this.arcsizeField;
            }
            set {
                this.arcsizeField = value;
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml", IncludeInSchema=false)]
    public enum ItemsChoiceType5 {
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:excel:ClientData")]
        ClientData,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:textdata")]
        textdata,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:anchorlock")]
        anchorlock,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderbottom")]
        borderbottom,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderleft")]
        borderleft,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderright")]
        borderright,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:bordertop")]
        bordertop,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:wrap")]
        wrap,
        
        
        fill,
        
        
        formulas,
        
        
        handles,
        
        
        imagedata,
        
        
        path,
        
        
        shadow,
        
        
        stroke,
        
        
        textbox,
        
        
        textpath,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml", IncludeInSchema=false)]
    public enum ItemsChoiceType6 {
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:excel:ClientData")]
        ClientData,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:powerpoint:textdata")]
        textdata,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:anchorlock")]
        anchorlock,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderbottom")]
        borderbottom,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderleft")]
        borderleft,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:borderright")]
        borderright,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:bordertop")]
        bordertop,
        
        
        [XmlEnum("urn:schemas-microsoft-com:office:word:wrap")]
        wrap,
        
        
        arc,
        
        
        curve,
        
        
        fill,
        
        
        formulas,
        
        
        group,
        
        
        handles,
        
        
        image,
        
        
        imagedata,
        
        
        line,
        
        
        oval,
        
        
        path,
        
        
        polyline,
        
        
        rect,
        
        
        roundrect,
        
        
        shadow,
        
        
        shape,
        
        
        shapetype,
        
        
        stroke,
        
        
        textbox,
        
        
        textpath,
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_EditAs {
        
        
        canvas,
        
        
        orgchart,
        
        
        radial,
        
        
        cycle,
        
        
        stacked,
        
        
        venn,
        
        
        bullseye,
    }
    
    
    [Serializable]

    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=true)]
    public class CT_Background {
        
        private CT_Fill fillField;
        
        private string idField;
        
        private ST_TrueFalse filledField;
        
        private bool filledFieldSpecified;
        
        private string fillcolorField;
        
        
        public CT_Fill fill {
            get {
                return this.fillField;
            }
            set {
                this.fillField = value;
            }
        }


        [XmlAttribute]
        public string id
        {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        
        [XmlAttribute]
        public ST_TrueFalse filled {
            get {
                return this.filledField;
            }
            set {
                this.filledField = value;
            }
        }
        
        
        [XmlIgnore]
        public bool filledSpecified {
            get {
                return this.filledFieldSpecified;
            }
            set {
                this.filledFieldSpecified = value;
            }
        }
        
        
        [XmlAttribute]
        public string fillcolor {
            get {
                return this.fillcolorField;
            }
            set {
                this.fillcolorField = value;
            }
        }
    }
    
    
    [Serializable]
    [XmlType(Namespace="urn:schemas-microsoft-com:vml")]
    [XmlRoot(Namespace="urn:schemas-microsoft-com:vml", IsNullable=false)]
    public enum ST_Ext 
    {       
        NONE,
        view,
        edit,
        backwardCompatible,
    }
}
