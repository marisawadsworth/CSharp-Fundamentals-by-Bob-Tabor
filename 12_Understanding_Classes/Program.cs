using System;

namespace _12_Understanding_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car
            {
                Make = "Holden",
                Model = "Cruze",
                Year = 2014,
                Colour = "Red"
            };

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Colour);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();
        }
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue; 
        }
    }
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Colour { get; set; }

            public decimal DetermineMarketValue()
            {
            decimal carValue;

            if (Year > 2005)
                carValue = 10000;
            else
                carValue = 5000;

            return carValue;
            }
    }
}