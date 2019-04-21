using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCodeLibrary;
//Reference Scrape for lesson 16.

namespace _16_Creating_and_Adding_References_to_Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
