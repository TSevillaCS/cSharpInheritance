using System;

namespace cSharpInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            Car myCar = new Car();

            //calling a method from myCar object
            myCar.horn();

            //display results on console, brand and model name
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}
