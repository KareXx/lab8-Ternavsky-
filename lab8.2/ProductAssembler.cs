using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class ProductAssembler
    {
        private AbstractProductFactory factory;

        public ProductAssembler(AbstractProductFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleProduct()
        {
            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine("Assembling product...");
            screen.Display();
            processor.Process();
            camera.Capture();

            Console.WriteLine("Product assembled successfully.");
        }
    }
}
