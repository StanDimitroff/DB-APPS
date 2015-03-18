namespace XsdSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;
    class TestProgram
    {
        static void Main()
        {
            string validDocument = "../../../catalog.xml";
            string invalidDocument = "../../../catalog-invalid.xml";
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "../../catalog.xsd");

            ValidateDocument(validDocument, schemas);
            ValidateDocument(invalidDocument, schemas);
        }

        private static void ValidateDocument(string path, XmlSchemaSet schemas)
        {
            XDocument doc = XDocument.Load(path);
            bool errors = false;
            doc.Validate(schemas, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message);
                errors = true;
            });

            Console.WriteLine("Document {0} {1}", path.Substring(9), errors ? "did not validate." : "validated.");
            Console.WriteLine();
        }
    }
}