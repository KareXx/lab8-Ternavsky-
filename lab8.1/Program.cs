using System;
using System.Collections.Generic;
using System.Linq;

namespace lab8._1 {
    class Program
    {
        static void Main()
        {
            GraphFactory factory = null;

            while (true)
            {
                Console.WriteLine("Введіть тип графіка (line/bar/pie/exit):");
                string graphType = Console.ReadLine().ToLower();

                if (graphType == "exit")
                {
                    break;
                }

                switch (graphType)
                {
                    case "line":
                        factory = new LineGraphFactory();
                        break;
                    case "bar":
                        factory = new BarGraphFactory();
                        break;
                    case "pie":
                        factory = new PieChartFactory();
                        break;
                    default:
                        Console.WriteLine("Невірний тип графіка.");
                        continue;
                }

                IGraph graph = factory.CreateGraph();
                List<int> data = new List<int> { 3, 6, 2, 8, 4 };
                graph.Draw(data);
                Console.ReadLine();

            }
        }
    }

}
