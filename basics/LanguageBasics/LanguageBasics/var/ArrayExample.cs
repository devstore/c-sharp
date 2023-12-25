using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics.array
{
    public class ArrayExample
    {
        public void printArray()
        {
            Console.WriteLine("");
            Console.WriteLine("Printing Array");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
              Console.WriteLine(i);
            }
        }
    }
}
