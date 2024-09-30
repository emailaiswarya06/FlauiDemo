using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlauiTests.Framework;
using FlauiTests.Pages;
using NUnit.Framework;

namespace FlauiTests.Tests
{
    class RegistrationTest : BaseTest
    {
        [Test]
        public void RegistionTest()
        {
            RegistrationPage register = new RegistrationPage();
            Assert.That(register.Registration().Contains("Success"));

        }
    }
}
