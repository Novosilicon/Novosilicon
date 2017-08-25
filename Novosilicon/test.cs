using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Novosilicon
{
    class FirstTest
    {
        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Test");
            IWebDriver Driver = new ChromeDriver();
            Driver.Url="http://www.google.com";
        }
    }
}
