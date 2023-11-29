using System;
using System.Diagnostics;


namespace lab8 {
    class Program
    {
        static void Main()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            while (true)
            {
                Console.WriteLine($"To change configuration press 1");
                Console.WriteLine($"To view the configuration press 2");
                Console.WriteLine($"Press 3 to finish");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "1":
                        Console.WriteLine($"Initial Logging Mode: {configManager.LoggingMode}");
                        Console.WriteLine($"Initial Database Connection: {configManager.DatabaseConnection}");

                        Console.Write("Enter new Logging Mode: ");
                        configManager.LoggingMode = Console.ReadLine();

                        Console.Write("Enter new Database Connection: ");
                        configManager.DatabaseConnection = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine($"Updated Logging Mode: {configManager.LoggingMode}");
                        Console.WriteLine($"Updated Database Connection: {configManager.DatabaseConnection}");
                        ConfigurationManager anotherConfigManager = ConfigurationManager.Instance;
                        Console.WriteLine($"Are the instances the same? {configManager == anotherConfigManager}");
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }


            }

        }
    }
}
