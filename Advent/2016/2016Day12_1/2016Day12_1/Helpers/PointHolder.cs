using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016Day12_1.Helpers
{
    public static class PointHolder
    {
        private static List<Point> _point;

        static PointHolder()
        {
            _point = new List<Point>();
        }

        public static void Change(Point point)
        {
            _point[0] = point;
        }
    }
}
