using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class SmartphoneFactory : AbstractProductFactory
    {
        public override Screen CreateScreen()
        {
            return new AMOLED();
        }

        public override Processor CreateProcessor()
        {
            return new Snapdragon();
        }

        public override Camera CreateCamera()
        {
            return new DualCamera();
        }
    }
}
