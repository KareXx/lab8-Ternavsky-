using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._3
{
    public interface IDataTemplate
    {
        IDataTemplate Clone();
        void ReadData(string filePath);
        void WriteData(string filePath);
        void ConvertData(IDataTemplate destinationTemplate);
    }
}
