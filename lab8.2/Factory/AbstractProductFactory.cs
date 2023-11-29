using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    abstract class AbstractProductFactory
    {
        public abstract Screen CreateScreen();
        public abstract Processor CreateProcessor();
        public abstract Camera CreateCamera();
    }
}
