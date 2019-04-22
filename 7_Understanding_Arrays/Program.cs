using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Understanding_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //An array is a collection of data you want to keep together.
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //Accessing the 2nd number of the array.
            Console.WriteLine(numbers[1]);
            //See how many items are in the array using the length property.
            Console.WriteLine(numbers.Length);
            Console.ReadLine();


            //int[] numbers = new int[] {4, 8, 15, 16, 23, 42 };

            //Goes through each name till the end to find out how many names are in the array.
            //First way
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */


            //string[] names = new string[] {"Marisa", "Caleb", "Cruise", "Rocco", "Mickey" };

            //Create a foreach loop and go through every name in the array of names and for each item
            //it will copy it to the varible "name" of type string, and print it out.
            //Second way
            /*
            foreach (string name in names) 
            {
                Console.WriteLine(name); 
            }
            Console.ReadLine();
            */



            //Take a string and reverse it.
            //Take a string and convert it into an array of individual characters, them tell it to reserve each item.
            string zig = "You can get what you want out of life" + //broke string to make it shorter.
                "If you help enough people get what they want.";

            //char means one character.
            //.ToCharArray is a helper method, this will take a long string and spilt it into individual characters and put them into an array.
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray) 
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}