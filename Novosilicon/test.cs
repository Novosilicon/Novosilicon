using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using Novosilicon.Core;

namespace Novosilicon
{
    class FirstTest : BaseTest
    {
        [Test]
        public void Test1()
        {
            System.Console.WriteLine("Test");
            Browser.Driver.Url = "http://www.ya.ru";
            
        }
        [Test]
        public void Test2()
        {
            Browser.Driver.Url = "http://www.drom.ru";

        }
    }
}
