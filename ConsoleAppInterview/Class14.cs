using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    public delegate void test();
    public delegate void addnumber();
    internal class Class14
    {
        public void test()
        {
            Console.WriteLine("hello world");
        }
        public void addnum()
        {
           int a=12 ,b = 25;
            Console.WriteLine(a+b);
        }
    }
}
