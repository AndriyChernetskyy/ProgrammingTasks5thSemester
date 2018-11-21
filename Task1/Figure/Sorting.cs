using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Figure
{
    public class Sorting
    {
       
        public List<IShape> listOfShapes = new List<IShape>();

        public Sorting()
        {
            this.listOfShapes = parseDataFromString();
            this.WriteSortedCollectionToFile();
            this.writeFiguresFromThirdQuarterToFile();
        }


        public static List<string> getDataFromFile()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Comp\Documents\Visual Studio 2017\Projects\Task1\data.txt");
            List<string> dataList = new List<string>();
            while (!sr.EndOfStream)
            {
                dataList.Add(sr.ReadLine());
            }
            return dataList;
        }

       
        public static List<IShape> parseDataFromString()
        {
            Circle bufferCircle = new Circle();
            Square bufferSquare = new Square();
            Triangle bufferTriangle = new Triangle();
            List<IShape> bufferShapesList = new List<IShape>();
            foreach (var line in getDataFromFile())
            {
                var dataFromLine = line.Split(' ');
                string typeOfShape = dataFromLine[0];

                switch (typeOfShape)
                {
                    case "Circle":
                        bufferShapesList.Add(bufferCircle.ReadFromFile(line));
                        break;
                    case "Square":
                        bufferShapesList.Add(bufferSquare.ReadFromFile(line));
                        break;
                    case "Triangle":
                        bufferShapesList.Add(bufferTriangle.ReadFromFile(line));
                        break;
                    default:
                        break;
                }
            }
            return bufferShapesList;
        }


        internal void WriteSortedCollectionToFile()
        {
            var sortedList = this.listOfShapes.OrderByDescending(shape => shape.FigurePerimeter());
            var list = sortedList.Reverse();
            StreamWriter sw = new StreamWriter(@"C:\Users\Comp\Documents\Visual Studio 2017\Projects\Task1\file1.txt", false, System.Text.Encoding.Default);
            sw.WriteLineAsync("Shapes sorted by perimeter(Ascending):");
            foreach (var shape in sortedList)
            {
                var s = shape as IFileManager;
                s.WriteToFile(sw);
            }
            sw.Close();
        }

        
        public static bool IsInThirdQuarter(IShape shape)
        {
            bool result = true;
            foreach (var point in shape.GetPoints())
            {
                result = result && ((point.x < 0) && (point.y < 0));
            }
            return result;
        }

        
        public List<IShape> getFiguresFromThirdQuarter()
        {
            List<IShape> figuresFromThirdQuarter = new List<IShape>();
            foreach (var figure in this.listOfShapes)
            {
                if (IsInThirdQuarter(figure))
                {
                    figuresFromThirdQuarter.Add(figure);
                }
                else continue;
            }
            return figuresFromThirdQuarter;
        }

       
        internal void writeFiguresFromThirdQuarterToFile()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Comp\Documents\Visual Studio 2017\Projects\Task1\file2.txt", false, System.Text.Encoding.Default);
            sw.WriteLineAsync("Figures from 3rd quarter sorted by perimeter(Descending):");
            var shapesFromThirdQuarter = this.getFiguresFromThirdQuarter();
            var sortedShapes = shapesFromThirdQuarter.OrderByDescending(shape => shape.FigurePerimeter());
            foreach (var shape in sortedShapes)
            {
                sw.WriteLineAsync(shape.ToString());
            }
            sw.Close();
        }








    }
}
