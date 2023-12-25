using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageBasics.variables
{
    public class Variables
    {
       public void printVariables() {
            
            
            int myNum = 15;
            Console.WriteLine("Integer value="+myNum);

            string greeting = "Merry Christman";
            Console.WriteLine("String greeting=" + greeting);

            //String Interpolation
            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            bool isCSharpFun = true;
            Console.WriteLine("bool="+isCSharpFun);   // Outputs True
        }


    }
}
