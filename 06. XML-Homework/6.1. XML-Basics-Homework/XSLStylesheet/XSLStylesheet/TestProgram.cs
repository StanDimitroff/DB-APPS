namespace XSLStylesheet
{
    using System.Xml.Xsl;

    class TestProgram
    {
        static void Main()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("../../students.xslt");
            xslt.Transform("../../students.xml", "../../students.html");
        }
    }
}