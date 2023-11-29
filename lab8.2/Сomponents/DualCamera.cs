using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class DualCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Dual camera is capturing photos.");
        }
    }
}
