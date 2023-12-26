using LanguageBasics.variables;
using LanguageBasics.array;
using System;
using LanguageBasics.accessors;
using LanguageBasics.inheritance;

namespace languageBasics
{
    class Startup
    {
        //program stating point
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program");
            Variables v= new Variables();
            v.printVariables();

            ArrayExample a=new ArrayExample();
            a.printArray();

            Person n=new Person();
            n.Name = "Ashu";
            n.Age = 35;
            Console.WriteLine();
            Console.WriteLine("Person="+n.Name);
            Console.WriteLine("Age="+n.Age);

            Vehicle vehicle=new Vehicle();
            Console.WriteLine(vehicle.Brand);

            Car car=new Car();
            car.honk();//inherited method from Vehicle

        }
    }
}