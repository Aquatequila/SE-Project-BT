using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGOperationsAndStructure
{
    public class PointFactory
    {
        public PointFactory() {}

        public PointData MCmd(double x, double y)
        {
            PointData returnValue   = new PointData();

            returnValue.type        = PointType.M;
            returnValue.x           = x;
            returnValue.y           = y;

            return returnValue;
        }
        public PointData mCmd(double x, double y)
        {
            PointData returnValue   = new PointData();

            returnValue.type        = PointType.m;
            returnValue.x           = x;
            returnValue.y           = y;

            return returnValue;
        }
        public PointData LCmd(double x, double y)
        {
            PointData returnValue   = new PointData();

            returnValue.type        = PointType.L;
            returnValue.x           = x;
            returnValue.y           = y;

            return returnValue;
        }
        public PointData lCmd(double x, double y)
        {
            PointData returnValue   = new PointData();
            returnValue.type        = PointType.l;
            returnValue.x           = x;
            returnValue.y           = y;

            return returnValue;
        }

        public PointData QCmd(double x, double y, double x1, double y1)
        {
            PointData returnValue   = new PointData();

            returnValue.type        = PointType.Q;
            returnValue.x           = x;
            returnValue.y           = y;
            returnValue.x1          = x1;
            returnValue.y1          = y1;

            return returnValue;
        }

        public PointData qCmd(double x, double y, double x1, double y1)
        {
            PointData returnValue   = new PointData();

            returnValue.type        = PointType.q;
            returnValue.x           = x;
            returnValue.y           = y;
            returnValue.x1          = x1;
            returnValue.y1          = y1;

            return returnValue;
        }

        public PointData ACmd(double x, double y, double rx, double ry, double xAxisRotation, double largeArc, double sweep)
        {
            PointData returnValue       = new PointData();

            returnValue.type            = PointType.A;
            returnValue.x               = x;
            returnValue.y               = y;
            returnValue.rx              = rx;
            returnValue.ry              = ry;
            returnValue.xAxisRotation   = xAxisRotation;
            returnValue.largeArc        = largeArc;
            returnValue.sweep           = sweep;

            return returnValue;
        }
        public PointData aCmd(double x, double y, double rx, double ry, double xAxisRotation, double largeArc, double sweep)
        {
            PointData returnValue       = new PointData();

            returnValue.type            = PointType.a;
            returnValue.x               = x;
            returnValue.y               = y;
            returnValue.rx              = rx;
            returnValue.ry              = ry;
            returnValue.xAxisRotation   = xAxisRotation;
            returnValue.largeArc        = largeArc;
            returnValue.sweep           = sweep;

            return returnValue;
        }

        public PointData DeepCopyPoint(ref PointData toCopy)
        {
            PointData returnValue       = new PointData();

            returnValue.type            = toCopy.type;
            returnValue.x               = toCopy.x;
            returnValue.y               = toCopy.y;
            returnValue.xAxisRotation   = toCopy.xAxisRotation;
            returnValue.largeArc        = toCopy.largeArc;
            returnValue.sweep           = toCopy.sweep;
            returnValue.rx              = toCopy.rx;
            returnValue.ry              = toCopy.ry;
            returnValue.x1              = toCopy.x1;
            returnValue.y1              = toCopy.y1;

            return returnValue;
        }
    }
    
}

