using System;
using lab8._2;

namespace lab8._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the type of product to assemble:");
            Console.WriteLine("1. Smartphone");

            int choice = int.Parse(Console.ReadLine());

            AbstractProductFactory factory = null;

            switch (choice)
            {
                case 1:
                    factory = new SmartphoneFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            ProductAssembler assembler = new ProductAssembler(factory);
            assembler.AssembleProduct();
        }
    }
}


