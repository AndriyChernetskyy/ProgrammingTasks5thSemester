using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Point
    {
        public int x {get; set;}
        public int y { get; set; }


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }





        public static double Distanse_Points(Point x1, Point y1)
        {
            return Math.Sqrt(Math.Pow(x1.x - y1.x, 2) + Math.Pow(x1.y - y1.y, 2));
        }
    }
}
