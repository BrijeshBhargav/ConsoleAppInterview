using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class2
    {
        public static void tes()
        {
            string[] arr = { "brijesh","bhargav" };
         
            Console.WriteLine("original array");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
           
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array= ");
            foreach (string j in arr)
            {
                Console.WriteLine(j);
                
            }
        }
        public static void tes2()
        {
            Console.WriteLine("enter the number");
            int number=int.Parse(Console.ReadLine());
            int sum = 0,reminder;
            while(number>0)
            {
                reminder = number % 10;
                sum=sum+reminder;   
                number=number/10;
            }
            Console.WriteLine($"The Sum of Digits is : {sum}");
            Console.ReadKey();

        }
        public static void tes3()
        {
                Console.Write("Enter the Binary Number : ");
                int binaryNumber = int.Parse(Console.ReadLine());
                int decimalValue = 0;

                // initializing base1 value to 1, i.e 2^0 
                int base1 = 1;
                while (binaryNumber > 0)
                {
                    int reminder = binaryNumber % 10;
                    binaryNumber = binaryNumber / 10;
                    decimalValue = reminder * base1;
                    base1 = base1 * 2;
                }
                Console.Write($"Decimal Value : {decimalValue} ");

                Console.ReadKey();
            }
        }
   
    }

    
