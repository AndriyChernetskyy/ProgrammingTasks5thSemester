using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Figure
{
    public class Square : IShape , IFileManager
    {

        public Point UpperLeft { get; set; }
        public Point LowerRight { get; set; }
        private List<Point> points = new List<Point>();

        public Square()
        {

        }
        public Square(Point upperLeft, Point lowerRight)
        {
            this.UpperLeft = upperLeft;
            this.LowerRight = lowerRight;
        }

        
        
        public double FigurePerimeter()
        {
            var squareSide = Math.Sqrt(2) * Point.Distanse_Points(UpperLeft, LowerRight);
            return 4 * squareSide;
        }

        
        public double FigureSquare()
        {
            var squareSide = Math.Sqrt(2) * Point.Distanse_Points(UpperLeft, LowerRight);
            return Math.Pow(squareSide, 2);
        }

        public List<Point> GetPoints()
        {
            return this.points;
        }


        public override string ToString()
        {
            return $"Square:     ({this.UpperLeft.x},{this.UpperLeft.y})  " +
                   $"({this.LowerRight.x},{this.LowerRight.y}) " +
                   $"square : {this.FigureSquare().ToString("0.00")}  " +
                   $"perimeter : {this.FigurePerimeter().ToString("0.00")}";
        }





        public IShape ReadFromFile(string dataLine)
        {
            var bufferObjectData = dataLine.Split(' ');
            var x1 = int.Parse((bufferObjectData[1]));
            var y1 = int.Parse((bufferObjectData[2]));
            var x2 = int.Parse((bufferObjectData[3]));
            var y2 = int.Parse((bufferObjectData[4]));

            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);

            Square square = new Square(p1, p2);
            square.points.Add(p1);
            square.points.Add(p2);

            return square;
        }

        public void WriteToFile(StreamWriter sw)
        {
            sw.WriteLineAsync(this.ToString());
        }
    }
}

