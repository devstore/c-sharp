using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics.accessors
{
    internal class Person
    {
        private string name;
        public int Age { get; set; } //Automatic properties

        public string Name 
        { 
            get => name; //get accessor for name property
            set => name = value; //set accessor for name property
        }


    }
}
