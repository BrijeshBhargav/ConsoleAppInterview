using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleAppInterview
{
    internal class Fibnoci
    {

        public static void Reverse()
        {
            string[] arr = { "brijesh", "bhargav" };
            Console.WriteLine("original array");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            // Reverse Array
            Array.Reverse(arr);
            Console.WriteLine("Reversed Array= ");
            foreach (string j in arr)
            {
                Console.WriteLine(j);
            }
        }
        public void test()
        {
            int a = 0, b = 1, c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = a + b;
            Console.WriteLine(c);
            for (int i = 0; i < c; i++)
            {
                if (c <= 50)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.WriteLine(c);
                }
            }
        }
        public static void fibnoc()
        {
            int n1 = 0, n2 = 1, num;

            Console.WriteLine(n1 + "", n2 + "");
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            for (int i = 3; i <= num; i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
        }
        public static void Palindrome()
        {
            var sum = 0;
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                var r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;

                if (temp == sum)
                {
                    Console.WriteLine(" is a Palindrome number");
                }
                else
                {
                    Console.WriteLine(" is not a Palindrome number");
                }
            }
        }
            public static void amstrong()
            {
                int num, sum = 0, rem;
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
              string s = num.ToString();
              int l= s.Length;
                int temp = num;
                while (num > 0)
                {
                    rem = num % 10;
                    sum = sum + (int)Math.Pow(rem,l);
                    num = num / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine("amstrong Number");
                }
                else
                {
                    Console.WriteLine("not an Amstrong");
                }
                Console.ReadLine();
            }
            public static void factorial()
            {
                int i, fact = 1, number;
                Console.WriteLine("Enter any number");
                number = int.Parse(Console.ReadLine());
                for (i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"factorial of {number} + is : {fact}");
            }
            public static void sum()
            {
                int n, sum = 0, rem;
                Console.WriteLine("Enter a number");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    rem = n % 10;
                    sum = sum + rem;
                    n = n / 10;
                }
                Console.Write("Sum is= " + sum);
            }
            public static void Triangle()
            {
                int i, j, k, l, n;
                Console.Write("Enter the Range=");
                n = int.Parse(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                    for (l = i - 1; l >= 1; l--)
                    {
                        Console.Write(l);
                    }
                    Console.Write("\n");
                }
            }

        }
    }


