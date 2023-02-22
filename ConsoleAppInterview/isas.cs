using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class isas
    {
        public static void test()
        {
            string name = "Brijesh";
            string lastname = "bhargav";
            Console.WriteLine(name + lastname);
            //Console.WriteLine(name is int); ---returns false
            string str = name as string;
            if (str != null)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("null");
            }
        }
        //The is operator is used to check if the run-time type of an object is compatible with the given type or not whereas as operator is used to perform conversion between compatible reference types or Nullable types.
        //The is operator is of boolean type whereas as operator is not of boolean type.
        //The is operator returns true if the given object is of the same type whereas as operator returns the object when they are compatible with the given type.
        //The is operator returns false if the given object is not of the same type whereas as operator return null if the conversion is not possible.
        public static void test2()
        {
            //int i = 100;
            //object obj = i;
            //i = 200;
            //Console.WriteLine(i);
            //Console.WriteLine(obj); 

            int j = 100;
            object obj1 = j;
             int z = (int)obj1;
            Console.WriteLine(z);

        }
      public static void test3()
        {
            int a = 20;
            fun(ref a);
            Console.WriteLine(a);
        }
        public static void fun(ref int b)
        {
            b += 15;
        }
        public static void test4()
        {
            int c = 25;
            fun2(out c);
            Console.WriteLine(c);
        }
        public static void fun2(out int d)
        {
             d = 35;
             d += 20;
        }
        public static void demo()
        {
            /* it is used when the type of the value is not known
                 * var is used to contain all types of value and the var is used to assign the data type at compile time
                 */
            var v1 = 12;

            var v2 = "Name";
            var v3 = 'A';
            var v4 = true;
            var v5 = 22.3;
            var v6 = 22344;
            /* var v1 = 50;
              * var v2 = 50;
              * var v3 = v1 + v2; */
            //dynamic is used to assign data type at run time and it is used to change the state based on the newly assigned value

            dynamic d1 = "yysv@bfwwuyvb";
            dynamic d2 = 45;
            dynamic d3 = false;
            dynamic d4 = 12.5;

            /* dynamic d1 = 30;
              * dynamic d2 = 60;
              * dynamic d3 = d1 + d3; */

            // objects are same as dynamic type but the objects are used to change the value through convertion operation and it uses subtraction operator
            // Object is an instance of a class. All the members of the class can be accessed through object.
            // The compiler has little information about the type.

            object o1 = "abc";
            object o2 = 123;
            object o3 = false;
            object o4 = 13.5;
            /* object o1 = 60;
              * object o2 = 40;
              * object o3 = Convert.Toint32(o1) - Convert.Toint32(o2) */
        }
    }
}
