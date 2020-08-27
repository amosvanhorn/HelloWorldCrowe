using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;

namespace AmosVanHorn.Services.Test
{
    [TestClass]
    public class MessageWriterServiceTests
    {
        [TestMethod]
        public void TestDefaultMessageWriterOutput()
        {
            // set test text
            var testText = "Hello World Default";

            // get message writer service
            var svc = new MessageWriterService();

            StringBuilder builder = new StringBuilder();
            TextWriter writer = new StringWriter(builder);
            Console.SetOut(writer);

            // write message, letting service using default writer (which is set to ConsoleMessageWriter in the config)
            svc.WriteMessage(testText);

            // read the console to determine if it wrote correctly
            Assert.AreEqual(testText, builder.ToString());
        }

        [TestMethod]
        public void TestConsoleMessageWriterOutput()
        {
            // set test text
            var testText = "Hello World Console";

            // get message writer service
            var svc = new MessageWriterService();

            StringBuilder builder = new StringBuilder();
            TextWriter writer = new StringWriter(builder);
            Console.SetOut(writer);

            // write message, passing specific writer 
            svc.WriteMessage(testText, new MessageWriters.ConsoleMessageWriter());

            // read the console to determine if it wrote correctly
            Assert.AreEqual(testText, builder.ToString());
        }
    }
}
