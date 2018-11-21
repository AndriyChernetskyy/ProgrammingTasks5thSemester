using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public interface IShape
    {
        double FigureSquare();
        double FigurePerimeter();
        List<Point> GetPoints();
    }
}
