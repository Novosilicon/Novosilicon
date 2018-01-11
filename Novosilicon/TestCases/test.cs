using NUnit.Framework;
using Novosilicon.Core;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;


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
            System.Console.WriteLine("Test2");

        }
        [Test]
        public void Test3()
        {
            
            Browser.Driver.Url = "http://www.drom.ru";
            IWebElement button = Browser.Driver.FindElement(By.XPath("//a[@class='b-menu__item-link']"));
            button.Click();
            System.Console.WriteLine("Test3");

        }
    }
}
