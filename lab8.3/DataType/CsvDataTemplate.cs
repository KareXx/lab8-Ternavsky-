using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._3.DataType
{
    public class CsvDataTemplate : IDataTemplate
    {
        public IDataTemplate Clone()
        {
            return new CsvDataTemplate();
        }


        public void ReadData(string filePath)
        {
            Console.WriteLine($"Читання даних з файлу CSV: {filePath}");
        }

        public void WriteData(string filePath)
        {
            Console.WriteLine($"Запис даних у файл CSV: {filePath}");
        }

        public void ConvertData(IDataTemplate destinationTemplate)
        {
            Console.WriteLine("Конвертація у формат CSV завершена.");
        }
    }
}
