namespace XmlToHtml
{
    using System;
    using System.Xml.Xsl;
    class TestProgram
    {
        static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xslt");
            xslt.Transform("../../../catalog.xml", "../../catalog.html");
        }
    }
}