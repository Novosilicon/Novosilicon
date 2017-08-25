using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novosilicon.Core
{
    public class BaseTest : Browser
    {
        [SetUp]
        public void Initial() => Browser.InitBrowser("Chrome");

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Browser.CloseAllDrivers();
        }

    }
}
