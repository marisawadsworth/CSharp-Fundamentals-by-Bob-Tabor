using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _6_For_Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are going to declear the variable i and put its value to 0. As long as i is less than 10 
            //we are going to excute the code "Console.Writeline(i);"
            //Everytime it goes though it is increasing the value by 1 "i++"
            //To help remember to seprate them look at the semi-colums ";"
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i); 
                if (7 == i) 
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}
