using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGOperationsAndStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            PointFactory factory = new PointFactory();
            PointData data = factory.LCmd(12.04, 13.55);

            Console.WriteLine(data.ToString());


        }
    }
}
