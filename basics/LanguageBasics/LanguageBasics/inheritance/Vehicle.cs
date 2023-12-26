using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics.inheritance
{
    internal class Vehicle
    {
        private string brand="Ford";

        public string Brand
        {
            get => brand;
            set => brand = value;

        }

        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
