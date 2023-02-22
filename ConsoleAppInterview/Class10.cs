using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppInterview
{
    internal class Class10
    {
// Method overloading is nothing but writing multiple methods with same name.
//To overload methods, you should follow the below rules.
//oAll of the overloaded methods name should be same.
//oAny difference between the method arguments should be maintained.
//The difference may be in no.of arguments or the data types of arguments.
        public void Show(int n)
        {
            Console.WriteLine("An integer value is found: " + n);
        }
        public void Show(double d)
        {
            Console.WriteLine("A double value is found: " + d);
        }
        public void Show(string s)
        {
            Console.WriteLine("A string value is found: " + s);
        }
    }
}
