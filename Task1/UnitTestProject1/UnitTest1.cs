using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;
using System.IO;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateDistanseBetweenPoints()
        {
            Point a = new Point(3, 5);
            Point b = new Point(6, 1);


            double result = Point.Distanse_Points(a, b);

            Assert.AreEqual(result, 5);
        }

        /// <summary>
        /// The TestCalculateSquarePerimeter
        /// </summary>
        [TestMethod]
        public void TestCalculateSquarePerimeter()
        {

            Point a = new Point(3, 5);
            Point b = new Point(6, 1);
            Square c = new Square();

            c.UpperLeft = a;
            c.LowerRight = b;


            double result = c.FigurePerimeter();

            Assert.AreEqual(result, 28, 2842712474619);
        }

        /// <summary>
        /// The TestCalculateSquareSquare
        /// </summary>
        [TestMethod]
        public void TestCalculateSquareSquare()
        {

            Point a = new Point(3, 5);
            Point b = new Point(6, 1);
            Square c = new Square();

            c.UpperLeft = a;
            c.LowerRight = b;


            double result = c.FigureSquare();
            Assert.AreEqual(result, 50, 0000000000001);
        }

        /// <summary>
        /// The TestCalculateCircleSquare
        /// </summary>
        [TestMethod]
        public void TestCalculateCircleSquare()
        {
            Circle c = new Circle();
            c.radius = 10;

            double result = c.FigureSquare();

            Assert.AreEqual(result, 314, 159265358979);
        }

        /// <summary>
        /// The TestCalculateCirclePerimeter
        /// </summary>
        [TestMethod]
        public void TestCalculateCirclePerimeter()
        {
            Circle c = new Circle();
            c.radius = 10;

            double result = c.FigurePerimeter();

            Assert.AreEqual(result, 62, 8318530717959);
        }

        /// <summary>
        /// The TestCalculateTrianglePerimeter
        /// </summary>
        [TestMethod]
        public void TestCalculateTrianglePerimeter()
        {
            Triangle c = new Triangle();
            c.sideA = 3;
            c.sideB = 6;
            c.sideC = 8;

            double result = c.FigurePerimeter();

            Assert.AreEqual(result, 17);
        }

        /// <summary>
        /// The TestCalculateTriangleSquare
        /// </summary>
        [TestMethod]
        public void TestCalculateTriangleSquare()
        {
            Triangle c = new Triangle();
            c.sideA = 3;
            c.sideB = 6;
            c.sideC = 8;

            double result = c.FigureSquare();

            Assert.AreEqual(result, 7, 64444242571033);
        }

        /// <summary>
        /// The TestGetDataFromFile
        /// </summary>
        [TestMethod]
        public void TestGetDataFromFile()
        {
            Sorting c = new Sorting();
            List<string> expected = Sorting.getDataFromFile();

            List<string> actual = new List<string> {"Circle 1 8 14", "Circle 1 1 3", "Circle -1 -1 3", "Triangle 7 4 1 4 6 3", "Square -2 -2 -5 -10", "Triangle -5 -3 -1 -4 -5 -6"};

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// The TestStreamWriter
        /// </summary>
        [TestMethod]
        public void TestStreamWriter()
        {
            var strContent = string.Empty;
            using (var file = new StreamReader(@"C:\Users\Comp\Documents\Visual Studio 2017\Projects\Task1\testfile.txt"))
                strContent = file.ReadToEnd();
            Assert.AreEqual(strContent, "abc123");
        }

        /// <summary>
        /// The TestParseDataFromString
        /// </summary>
        [TestMethod]
        public void TestParseDataFromString()
        {
            List<IShape> c = Sorting.parseDataFromString();

            List<string> expected = new List<string>();
            List<string> actual = new List<string> { "Circle:     (1,8)  radius: 14 square : 615,75  perimeter : 87,96", "Circle:     (1,1)  radius: 3 square : 28,27  perimeter : 18,85", "Circle:     (-1,-1)  radius: 3 square : 28,27  perimeter : 18,85", "Triangle:   (7,4)  (1,4) (6,3) square : 3,00  perimeter : 12,51", "Square:     (-2,-2)  (-5,-10) square : 146,00  perimeter : 48,33", "Triangle:   (-5,-3)  (-1,-4) (-5,-6) square : 6,00  perimeter : 11,60" };

            foreach (IShape i in c)
            {
                expected.Add(i.ToString());
            }

            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// The TestIsInThirdQuarter
        /// </summary>
        [TestMethod]
        public void TestIsInThirdQuarter()
        {
            List<IShape> a = Sorting.parseDataFromString();

            //Circle -1 -1 3

            IShape expected = a[2];

            Assert.IsTrue(Sorting.IsInThirdQuarter(expected));
        }

        /// <summary>
        /// The TestGetFiguresFromThirdQuarter
        /// </summary>
        [TestMethod]
        public void TestGetFiguresFromThirdQuarter()
        {
            Sorting c = new Sorting();
            List<IShape> t = c.getFiguresFromThirdQuarter();

            List<string> expected = new List<string>();
            List<string> actual = new List<string> { "Circle:     (-1,-1)  radius: 3 square : 28,27  perimeter : 18,85", "Square:     (-2,-2)  (-5,-10) square : 146,00  perimeter : 48,33", "Triangle:   (-5,-3)  (-1,-4) (-5,-6) square : 6,00  perimeter : 11,60" };

            foreach (IShape i in t)
            {
                expected.Add(i.ToString());
            }

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
