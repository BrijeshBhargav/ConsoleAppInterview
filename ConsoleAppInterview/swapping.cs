using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class swapping
    {
        public static void swap()
        {
            int num1, num2,temp;
            Console.WriteLine("Enter num1 val");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2 val");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Before SWapping number1= {num1}, number2 = {num2}");
            temp = num1;
            num1= num2; 
            num2=temp;
            Console.WriteLine($"After swapping number1= {num1}, number2 = {num2}");
            Console.ReadKey();

        }
        public static void fibo()
        {
            int n1 = 0, n2 = 1;
          Console.WriteLine("enter a num");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + "" + n2 + "");
            for(int i=3;i<=num;i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
