using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._1
{
    class BarGraphFactory : GraphFactory
    {
        public override IGraph CreateGraph()
        {
            return new BarGraph();
        }
    }
}
