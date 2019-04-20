using System;
using System.IO;
using System.Net;


namespace _15_Understanding_Namespace_and_Working_with_the_.Net_Class_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //Looks up the microsoft website and downloads the code in the termial and on the computer.

            //Needs the using System.Net; to work.
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            //Dont need System as it is mentioned at the top.
            System.Console.WriteLine(reply);
            //Needs the using System.IO; to work. Saves the file onto the computer.
            File.WriteAllText(@"C:\Lesson17\WriteTxt.txt", reply);
            Console.ReadLine();

        }
    }
}