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
            // create message writer service
            var messageWriterService = new MessageWriterService();
            
            // write message (letting service use the default writer, which is specified in app.config)
            messageWriterService.WriteMessage("Hello World");

            // write press to exit message
            Console.WriteLine("\npress any key to exit...");

            // wait for user keypress before closing
            Console.ReadKey();
        }
    }
}
