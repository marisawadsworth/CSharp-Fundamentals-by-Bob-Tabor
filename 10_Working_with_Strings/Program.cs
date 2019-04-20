using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// / Fordslash
// \ Backslash

namespace _10_Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adds Brackets "" inside the string.
            //string myString = "My \"so called\" life";

            //Adds a new line in the same string.
            //string myString = "What if i want to add a\nnew line?";

            //Adds the \, two different ways.
            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your C:\ drive";

            //Replacement code, switching the numbers 1 and 0 around or 0 = 0 or 1 = 1.
            //string myString = String.Format("{0} = {1}", "First", "Second");

            //C formats it to a currency.
            //string myString = string.Format("{0:C}", 123.45);

            //N formats it to the correct format of a large number by adding in decimals and fullstops.
            //string myString = string.Format("{0:N}", 1234567890);

            //Shows the Percentage. 
            //string myString = string.Format("Percentage: {0:P}", .123);

            //The "#" puts the numbers in an order.
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);


            //string myString = " That summer we took threes across the board  ";

            //Starts on the 6th character which is "Summer" to the next 14 characters
            //myString = myString.Substring(6, 14);

            //Makes everything upper case
            //myString = myString.ToUpper();

            //Replaces the spaces to --.
            //myString = myString.Replace(" ", "--");

            //Can removes characters from a string
            //myString = myString.Remove(6, 14);

            //The length proberty tells us how long a string is
            //Trimed off spaces.
            //myString = String.Format("Length before {0} -- Length after {1}",
            //    myString.Length, myString.Trim().Length);

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //Working with strings in an efficient way.
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}