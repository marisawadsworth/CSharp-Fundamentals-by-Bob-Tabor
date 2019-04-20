using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Working_with_Dates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Displays both date and time.
            //Console.WriteLine(myValue.ToString());

            //Displays the date.
            //Console.WriteLine(myValue.ToShortDateString());

            //Displays the time.
            //Console.WriteLine(myValue.ToShortTimeString());

            //Displays the long version of the date.
            //Console.WriteLine(myValue.ToLongDateString());

            //Displays the long version of the time.
            //Console.WriteLine(myValue.ToLongTimeString());


            //Shows the date in 3 days time.
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //Shows the time in 3 hours.
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //Shows the date in 3 days ago.
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());


            //Shows the current month.
            //Console.WriteLine(myValue.Month);

            //Shows my birthday.
            /*
            DateTime myBirthday = new DateTime(1998, 8, 26);
            Console.WriteLine(myBirthday.ToShortDateString());
            */

            DateTime myBirthday = new DateTime(1998, 8, 26);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
