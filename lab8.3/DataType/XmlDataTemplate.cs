using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._3.DataType
{
    public class XmlDataTemplate : IDataTemplate
    {
        public IDataTemplate Clone()
        {
            return new XmlDataTemplate();
        }


        public void ReadData(string filePath)
        {
            Console.WriteLine($"Читання даних з файлу XML: {filePath}");
        }

        public void WriteData(string filePath)
        {
            Console.WriteLine($"Запис даних у файл XML: {filePath}");
        }

        public void ConvertData(IDataTemplate destinationTemplate)
        {
            Console.WriteLine("Конвертація у формат XML завершена.");
        }
    }
}
