using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class11
    {
     
            public static void test()

            {

                Stack<string> names = new Stack<string>();

                names.Push("Sonoo");

                names.Push("Peter");

                names.Push("James");

                names.Push("Ratan");

                names.Push("Irfan");
                names.Pop();
                foreach (string item in names)

                {
                    Console.WriteLine(item);
                }

              

            }


        }
    }
