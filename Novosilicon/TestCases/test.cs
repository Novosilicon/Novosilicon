using NUnit.Framework;
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
            System.Console.WriteLine("Test2");

        }
        [Test]
        public void Test3()
        {
            
            Browser.Driver.Url = "http://www.drom.ru";
            System.Console.WriteLine("Test3");

        }
    }
}
