using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_More_About_Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Holden";
            myCar.Model = "Cruze";
            myCar.Year = 2014;
            myCar.Colour = "Red";

            //Car myThirdCar = new Car("Ford", "Escape", 2005, "Blue");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Colour);


            myOtherCar.Make = "Holden";
            myOtherCar.Model = "V8";
            myOtherCar.Year = 2014;
            myOtherCar.Colour = "Red";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Colour);
            */    

            Console.ReadLine();
        }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        /*
        public Car()
        {
            //You could load from a configuration file, a database, etc ...       
            Make = "Nissan";
        }


        public Car(string make, string model, int year, string colour) 
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        */
        public static void MyMethod() 
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make);
        }
    }
}