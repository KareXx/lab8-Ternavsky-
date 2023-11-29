using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._3
{
    public interface IDataAdapter
    {
        void ConvertData(string sourcePath, string destinationPath);
    }
}
