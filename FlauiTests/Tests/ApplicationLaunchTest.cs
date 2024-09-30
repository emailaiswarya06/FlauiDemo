using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlauiTests.Framework;
using NUnit.Framework;

namespace FlauiTests.Tests
{
    class ApplicationLaunchTest : BaseTest
    {
        [Test]
        public void LaunchApplication()
        {
            Console.WriteLine("Launch Application");
            Assert.That(mainWindow != null, "Flaui was not able to launch the application and get the main window");
        }
    }
}
