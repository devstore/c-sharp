using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics.inheritance
{
    internal class Car : Vehicle
    {
        private string modeName="Mustang";

        public string ModelName{ get => modeName; set => modeName = value; }
    }
}
