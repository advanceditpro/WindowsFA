using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace WindowsFA
{
    public class XmlWriterSettingsLibrary
    {
        public XmlWriterSettingsLibrary()
        {
            maindocxmlsettings = new XmlWriterSettings();
            maindocxmlsettings.Indent = true;
            maindocxmlsettings.IndentChars = ("    ");
            maindocxmlsettings.OmitXmlDeclaration = false;
            maindocxmlsettings.ConformanceLevel = ConformanceLevel.Document;

            fragmentxmlsettings = new XmlWriterSettings();
            fragmentxmlsettings.Indent = true;
            fragmentxmlsettings.IndentChars = ("    ");
            fragmentxmlsettings.OmitXmlDeclaration = true;
            fragmentxmlsettings.ConformanceLevel = ConformanceLevel.Fragment;
        }
        public XmlWriterSettings maindocxmlsettings;
        public XmlWriterSettings fragmentxmlsettings;
    }

}
