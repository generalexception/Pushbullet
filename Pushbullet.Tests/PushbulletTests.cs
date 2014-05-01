using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pushbullet.Client;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace Pushbullet.Tests
{
    [TestClass]
    public class PushbulletTests
    {
        private static string TestDeviceId;

        [ClassInitialize()]
        public static void InitializePushbulletTests(TestContext testContext)
        {
            PushbulletService.APIKEY = ConfigurationManager.AppSettings["APIKEY"];
            TestDeviceId = PushbulletService.GetDevices().devices.First(d => d.extras.model == "GT-I9300").iden;
        }

        [TestMethod]
        public void TestPushbulletNote()
        {
            PushMessage message = new PushMessage();
            message.device_iden = TestDeviceId;
            message.type = new Note { title = "Test C# API Title", body = "Test C# API Body" };
            PushResponse response = PushbulletService.Push(message);
            Assert.IsInstanceOfType(response, typeof(PushResponse));
        }

        [TestMethod]
        public void TestPushbulletList()
        {
            PushMessage message = new PushMessage();
            message.device_iden = TestDeviceId;
            message.type = new List { title = "Shopping", items = new List<string> { "Eggs", "Milk", "Bread", "Corn Flakes", "Butter" } };
            PushResponse response = PushbulletService.Push(message);
            Assert.IsInstanceOfType(response, typeof(PushResponse));
        }

        [TestMethod]
        public void TestPushbulletLink()
        {
            PushMessage message = new PushMessage();
            message.device_iden = TestDeviceId;
            message.type = new Link { title = "Test C# API Title", url = "http://www.google.co.uk" };
            PushResponse response = PushbulletService.Push(message);
            Assert.IsInstanceOfType(response, typeof(PushResponse));
        }

        [TestMethod]
        public void TestPushbulletAddress()
        {
            PushMessage message = new PushMessage();
            message.device_iden = TestDeviceId;
            message.type = new Address { name = "John Doe", address = "Big yella house" };
            PushResponse response = PushbulletService.Push(message);
            Assert.IsInstanceOfType(response, typeof(PushResponse));
        }
    }
}
