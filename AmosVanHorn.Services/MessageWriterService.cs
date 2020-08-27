using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmosVanHorn.Services.MessageWriters;

namespace AmosVanHorn.Services
{
    public class MessageWriterService : IMessageWriterService
    {
        public bool WriteMessage(string message, IMessageWriter messageWriter = null)
        {
            try
            {
                // get the messagewriter
                var writer = messageWriter ?? GetDefaultMessageWriter();

                // write the message
                writer.WriteMessage(message);

                // return true to indicate success
                return true;
            }
            catch(Exception ex)
            {
                // log error
                LogError(ex.Message);

                // return false to indicate failure
                return false;
            }
        }

        public IMessageWriter GetDefaultMessageWriter()
        {
            // get the default name from the config
            var defaultmessagewritername = ConfigurationManager.AppSettings["DefaultMessageWriter"];

            // create class instance
            var defaultmessagewriter = (IMessageWriter)Activator.CreateInstance(Type.GetType(defaultmessagewritername));

            // return IMessageWriter instance
            return defaultmessagewriter;
        }

        private void LogError(string message)
        {
            // log somewhere
        }
    }
}
