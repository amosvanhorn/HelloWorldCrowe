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

            // redirect the console output into a stringbuilder
            StringBuilder builder = new StringBuilder();
            TextWriter writer = new StringWriter(builder);
            Console.SetOut(writer);

            // get message writer service
            var svc = new MessageWriterService();

            // write message, letting service using default writer (which is set to ConsoleMessageWriter in the config)
            bool success = svc.WriteMessage(testText);

            // read the redirected console output to determine if it wrote correctly
            Assert.AreEqual(testText, builder.ToString());

            // make sure true was returned (and that a caught/logged exception didn't happen)
            Assert.AreEqual(success, true);
        }

        [TestMethod]
        public void TestConsoleMessageWriterOutput()
        {
            // set test text
            var testText = "Hello World Console";

            // redirect the console output into a stringbuilder
            StringBuilder builder = new StringBuilder();
            TextWriter writer = new StringWriter(builder);
            Console.SetOut(writer);

            // get message writer service
            var svc = new MessageWriterService();

            // write message, passing a specific IMessageWriter
            bool success = svc.WriteMessage(testText, new MessageWriters.ConsoleMessageWriter());

            // read the redirected console output to determine if it wrote correctly
            Assert.AreEqual(testText, builder.ToString());

            // make sure true was returned (and that a caught/logged exception didn't happen)
            Assert.AreEqual(success, true);
        }
    }
}
