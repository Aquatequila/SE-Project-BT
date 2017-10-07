using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGOperationsAndStructure
{
    class SVGDocumentWriter
    {
        private System.IO.StreamWriter document = null;

        public SVGDocumentWriter()
        {

        }

        public void WriteToFile (ref string filenameAndPath, ref SVGDocumentHandler source)
        {
            document = new System.IO.StreamWriter(filenameAndPath);

            source.WriteToFile(writeStartTag, endTagWithContent);

            document.Close();
        }
        private void writeAttributes(ref Dictionary<string, string> attributes)
        {
            foreach (KeyValuePair<string, string> entry in attributes)
            {
                writeAttribute(entry.Key, entry.Value);
            }
        }
        private void writeAttribute(string name, string value)
        {
            document.Write(" {0}=\"{1}\"", name, value);
        }

        private void startTag(ref string tagname)
        {
            document.Write("<{0}", tagname);
        }
        private void endTagWithContent(ref string tagname)
        {
            document.WriteLine("</{0}>", tagname);
        }

        private void endStartTag(bool tagHasContent = false)
        {
            if (!tagHasContent)
            {
                document.Write("/");
            }
            document.WriteLine(">");
        }
        private void writeStartTag(ref string tagname, ref Dictionary<string, string> attributes, bool hasContent)
        {
            startTag(ref tagname);
            writeAttributes(ref attributes);
            endStartTag(hasContent);
        }
    }
}
