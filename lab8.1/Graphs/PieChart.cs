using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._1
{
    internal class PieChart : IGraph
    {
        public void Draw(List<int> data)
        {
            Console.WriteLine("Кругова діаграма:");
            int total = data.Sum();
            double radius = 10;
            double angle = 0;

            for (int i = 0; i < data.Count; i++)
            {
                double percentage = (double)data[i] / total;
                int wedge = (int)(percentage * 360);

                for (int j = 0; j < wedge; j++)
                {
                    double radians = angle * (Math.PI / 180);
                    int x = (int)(radius * Math.Cos(radians));
                    int y = (int)(radius * Math.Sin(radians));

                    Console.SetCursorPosition(20 + x, 10 + y);
                    Console.Write("*");
                    angle++;
                }
            }

            Console.WriteLine();
        }
    }
}
