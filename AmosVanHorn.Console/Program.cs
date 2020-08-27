using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmosVanHorn.Services;

namespace HelloWorldAmosVanHorn
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageWriterService = new MessageWriterService();
            messageWriterService.WriteMessage("Hello World");

            Console.WriteLine("\npress any key to exit...");

            Console.ReadKey();
        }
    }
}
