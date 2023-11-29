using lab8._3.DataType;
using System;
using System.IO;

namespace lab8._3 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Виберіть формат вихідних даних (CSV, XML, JSON):");
            string sourceFormat = Console.ReadLine();

            Console.WriteLine("Виберіть формат цільових даних (CSV, XML, JSON):");
            string destinationFormat = Console.ReadLine();

            IDataTemplate sourceTemplate = GetTemplateByFormat(sourceFormat);
            IDataTemplate destinationTemplate = GetTemplateByFormat(destinationFormat);

            Console.WriteLine("Задайте шлях до вихідного файлу:");
            string outputFile = Console.ReadLine();

            Console.WriteLine("Задайте шлях до цільового файлу:");
            string inputFile = Console.ReadLine();


            IDataAdapter dataAdapter = new DataAdapter(sourceTemplate, destinationTemplate);
            dataAdapter.ConvertData(outputFile, inputFile);

            Console.WriteLine("Конвертація завершена!");
        }

        private static IDataTemplate GetTemplateByFormat(string format)
        {
            switch (format.ToUpper())
            {
                case "CSV":
                    return new CsvDataTemplate();
                case "XML":
                    return new XmlDataTemplate();
                case "JSON":
                    return new JsonDataTemplate();
                default:
                    throw new NotSupportedException("Непідтримуваний формат даних.");
            }
        }
    }
}

