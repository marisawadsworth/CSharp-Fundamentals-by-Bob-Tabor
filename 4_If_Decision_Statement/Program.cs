using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_If_Decision_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st Way

            Console.WriteLine("Marisa's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a car!";
            else if (userValue == "2")
                message = "You won a boat:";
            else if (userValue == "3")
                message = "You won a dog!";
            else
            {
                message = "Sorry we didn't understand. ";
                //message = message + "You Lose";
                message += "You Lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();

            //I have taken out the curly brackets and these line of code below to make my code shorter.
            //string message = "You won a car!";
            //Console.WriteLine(message);

            //This will only work if there is one line of code, since my else has two lines of code 
            //I need to add the curly brackets or it will read the last line and put in it all.
            //Example: 1 You won a car! You Lose.



            //2nd Way
            /*
            Console.WriteLine("Marisa's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "car!" : " ... Nothing";
            Console.WriteLine("You entered: {0}, therefore you won a {1}", userValue, message);
            Console.ReadLine();
            */
        }
    }
}