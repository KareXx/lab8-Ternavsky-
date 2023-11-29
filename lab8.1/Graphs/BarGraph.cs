using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._1
{
    public class BarGraph : IGraph
    {
        public void Draw(List<int> data)
        {
            Console.WriteLine("Стовпчиковий графік:");
            int maxData = data.Max();
            for (int i = maxData; i > 0; i--)
            {
                foreach (int value in data)
                {
                    if (value >= i)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < data.Count; j++)
                Console.Write($"{j + 1} ");
            Console.WriteLine();
        }
    }
}
