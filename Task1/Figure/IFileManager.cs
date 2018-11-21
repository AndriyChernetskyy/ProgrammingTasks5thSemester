using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Figure
{
    public interface IFileManager
    {
        IShape ReadFromFile(string sr);
        void WriteToFile(StreamWriter sw);

    }
}
