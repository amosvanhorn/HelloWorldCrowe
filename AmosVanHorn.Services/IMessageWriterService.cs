using AmosVanHorn.Services.MessageWriters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmosVanHorn.Services
{
    public interface IMessageWriterService
    {
        bool WriteMessage(string message, IMessageWriter messageWriter = null);
    }
}
