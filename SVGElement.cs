using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGOperationsAndStructure
{
    class SVGElement
    {
        private Dictionary<string, string> attributes;
        private String tagname;
        private String id;
        private List<PointData> path;
        //private Dictionary<string, SVGElement> childs;

        public SVGElement(ref string tagname)
        {
            this.tagname    = tagname;
            this.id         = ""; // TODO 
            this.attributes = new Dictionary<string, string>();
            this.path       = new List<PointData>();
            //this.childs     = new Dictionary<string, SVGElement>();
        }

        public ref string GetId()
        {
            return ref this.id;
        }

        public void SetAttribute(ref string attributeName, ref string attributeValue)
        {
            attributes[attributeName] = attributeValue;
        }

        public void RemoveAttribute(string attributeName)
        {
            attributes.Remove(attributeName);
        }

        public void SetTagName(string tagname)
        {
            this.tagname = tagname;
        }

        public ref string GetTagname()
        {
            return ref tagname;
        }

        public ref List<PointData> GetPath()
        {
            return ref path;
        }

        public void WriteToFile(tagWriter writeElement, endOfTagWithContent endTag)
        {
            string d = "";
            foreach(PointData point in path)
            {
                if (d != "")
                {
                    d += " ";
                }
                d += point.ToString();
            }
            attributes["d"] = d;
            writeElement(ref tagname, ref attributes, false);
        }
    }
}
