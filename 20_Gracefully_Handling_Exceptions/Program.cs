using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _20_Gracefully_Handling_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"Example.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly.");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the directory is named correctly.");
            }

            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }

            finally
            {
                //Code to finalize.
                //Setting objects to null.
                //Closing database connections.
                Console.WriteLine("Closing application now ...");
            }
            Console.ReadLine();
        }
    }
}
