using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("anil loves ");

        }
        static Constructor()
        {
            Console.WriteLine("anil loves ");
        }
        public Constructor(string a)
        {
            Console.WriteLine(a);
        }
        public Constructor(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}
