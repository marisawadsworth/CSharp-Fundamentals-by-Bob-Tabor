using System;
namespace _8_Defining_and_Calling_Methods
{
    public class Method
    {
        public Method()
        {
            //Methods help organise the code better, eliminate duplicate code, you can copy something and paste it later in the code.
            //Gives a feature or functionality a name and call it by its name anywhere in the application.
            //When you need to update you only need to go to that one place instead of the whole code.

            HelloWorld();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

    }
}
