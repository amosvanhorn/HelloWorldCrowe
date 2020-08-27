using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmosVanHorn.Services.MessageWriters
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            // write the line to console
            Console.Write(message);
        }
    }
}
