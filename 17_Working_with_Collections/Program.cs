using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Working_with_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Holden";
            car1.Model = "Cruze";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Holden";
            car2.Model = "V8";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Title = "Protector";
            b1.Author = "Joanne Wadsworth";
            b1.ISBN = "0-000-00000-0";

            /*
            //ArrayList are dynamically sized. Can keep adding items to it. Can store and remove items.
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */


            /*
            //Generic type lets us work with a data type and only allows those data to work.
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);

            /*
            //Object Initializer
            //No need for Constructors.
            Car car1 = new Car { Make = "BMW", Model = "750li", VIN = "C3"},
            Car car2 = new Car { Make = "Toyota", Model = "4Runner", VIN = "D4" };


            //Collection Initializer
            List<Car> myList = new List<Car>();
            {
                new Car { Make = "Nissian", Model = "Altima", VIN = "E5"},
                new Car { Make = "Ford", Model = "Focus", VIN = "F6" };
            }
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
