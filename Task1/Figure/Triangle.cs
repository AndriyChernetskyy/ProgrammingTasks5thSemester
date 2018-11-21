using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Figure
{
    public class Triangle : IShape , IFileManager
    {

        public Point firstPoint { get; set; }
        public Point secondPoint { get; set; }
        public Point thirdPoint { get; set; }

        private List<Point> points = new List<Point>();

        public double sideA;
        public double sideB;
        public double sideC;

        public Triangle()
        {
        }

        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.thirdPoint = thirdPoint;
            this.sideA = Math.Abs(Point.Distanse_Points(firstPoint, secondPoint));
            this.sideB = Math.Abs(Point.Distanse_Points(secondPoint, thirdPoint));
            this.sideC = Math.Abs(Point.Distanse_Points(thirdPoint, firstPoint));
        }



 
        public List<Point> GetPoints()
        {
            return this.points;
        }

        public double FigureSquare()
        {
            var halfPerimeter = FigurePerimeter() / 2;
            return Math.Sqrt(
                halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
        }


        public double FigurePerimeter()
        {
            return sideA + sideB + sideC;
        }


        public override string ToString()
        {
            return $"Triangle:   ({this.firstPoint.x},{this.firstPoint.y})  " +
                   $"({this.secondPoint.x},{this.secondPoint.y}) " +
                   $"({this.thirdPoint.x},{this.thirdPoint.y}) " +
                   $"square : {this.FigureSquare().ToString("0.00")}  perimeter : {this.FigurePerimeter().ToString("0.00")}";
        }






        public IShape ReadFromFile(string dataLine)
        {
            var bufferObjectData = dataLine.Split(' ');
            var x1 = int.Parse((bufferObjectData[1]));
            var y1 = int.Parse((bufferObjectData[2]));
            var x2 = int.Parse((bufferObjectData[3]));
            var y2 = int.Parse((bufferObjectData[4]));
            var x3 = int.Parse((bufferObjectData[5]));
            var y3 = int.Parse((bufferObjectData[6]));


            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            Point p3 = new Point(x3, y3);

            Triangle triangle = new Triangle(p1, p2, p3);

            triangle.points.Add(p1);
            triangle.points.Add(p2);
            triangle.points.Add(p3);

            return triangle;
        }

       
        public void WriteToFile(StreamWriter sw)
        {
            sw.WriteLineAsync(this.ToString());
        }
    }
}
