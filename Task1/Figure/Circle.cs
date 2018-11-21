using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Figure
{
    public class Circle : IShape , IFileManager 
    {

        public Point center { get; set; }
        public double radius;

        public List<Point> points = new List<Point>();



        public Circle()
        {
        }


        public Circle(Point center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }


        public double FigureSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double FigurePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public List<Point> GetPoints()
        {
            return points;
        }


        public override string ToString()
        {
            return $"Circle:     ({this.center.x},{this.center.y})  radius: {this.radius} " +
                   $"square : {this.FigureSquare().ToString("0.00")}  perimeter : {this.FigurePerimeter().ToString("0.00")}";
        }



        public IShape ReadFromFile(string dataString)
        {
            var str = dataString.Split(' ');
            var x = int.Parse((str[1]));
            var y = int.Parse((str[2]));
            var radius = int.Parse((str[3]));

            Point point = new Point(x, y);
            Circle circle = new Circle(new Point(x, y), radius);
            circle.points.Add(point);
            return circle;
        }


        public void WriteToFile(StreamWriter sw)
        {
            sw.WriteLineAsync(this.ToString());
        }



    }
}
