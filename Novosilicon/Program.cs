using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Novosilicon
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Configurations\ElementsList.xml");

            foreach (XmlNode node in doc.SelectNodes("//pages/*"))
            {
                System.Console.WriteLine(node.Name);
                foreach (XmlNode item in node)
                {
                    System.Console.WriteLine(item.Name);
                }
            }
            System.Console.ReadLine();

        }
    }
}
