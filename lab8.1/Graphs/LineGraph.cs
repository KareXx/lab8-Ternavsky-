using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._1
{
    public class LineGraph : IGraph
    {
        public void Draw(List<int> data)
        {
            Console.WriteLine("Лінійний графік:");
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {new string('*', data[i])}");
            }
        }
    }
}
