using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGOperationsAndStructure
{
    public delegate void tagWriter(ref string tagname, ref Dictionary<string, string> attributes, bool hasContent);
    public delegate void endOfTagWithContent(ref string tagname);

    class SVGDocumentHandler
    {
        private Dictionary<string, string> attributes;
        private static String tagname    = "svg";
        private const String xmlns      = "http://www.w3.org/2000/svg";
        private const String xlinkns    = "http://www.w3.org/1999/xlink";

        private Dictionary<string, SVGElement> childs;

        public SVGDocumentHandler(int width = 500, int height = 500)
        {
            if ((width < 0) || (height < 0))
            {
                throw new ArgumentOutOfRangeException("negative values for width and/or height make no sense");
            }
            this.attributes                 = new Dictionary<string, string>();
            this.attributes["xmlns"]        = xmlns;
            this.attributes["xmlns:xlink"]  = xlinkns;
            this.attributes["viewbox"]      = String.Format("0 0 {0} {1}", width, height);
            this.childs                     = new Dictionary<string, SVGElement>();
        }

        public void SetChild(ref string id, ref SVGElement element)
        {
            childs[id] = element;
        }
        public SVGElement GetChild(ref string id)
        {
            SVGElement returnValue;
            if (childs.TryGetValue(id, out returnValue))
            {
                return returnValue;
            }
            return null;
        }
        public bool RemoveChild(ref string id)
        {
            return childs.Remove(id);
        }

        public void WriteToFile (tagWriter writeElement, endOfTagWithContent endTag)
        {
            writeElement(ref tagname, ref attributes, true);

            foreach (KeyValuePair<string, SVGElement> elem in childs)
            {
                elem.Value.WriteToFile(writeElement, endTag);
            }

            endTag(ref tagname);
        }
    }
}
