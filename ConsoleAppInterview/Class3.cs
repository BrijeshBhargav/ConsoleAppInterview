using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class3
    {
        public static void sum()
        {
            int n, rem, sum = 0;
            Console.WriteLine("enter any num");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
        public static void btc()
        {
            int n, b = 1, sum = 0, rem;
            Console.WriteLine("enter a val");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("binary val :" + n);
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem * b;
                n = n / 10;
                b = b * 2;
            }
            Console.WriteLine("decimal val :" + sum);
        }
        public static void rev()
        {
            string s = string.Empty, r = string.Empty;
            Console.WriteLine("enter a string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            Console.WriteLine("the rev str:" + r);
        }
        public static void dtb()
        {
            int i;
            int[] a = new int[10];
            Console.Write("enter a num : ");
            int n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Decimal to binary :");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);

            }
            Console.WriteLine("");

        }
     
        public static void Charoc()
        {
            Console.Write("Enter a string : ");
            string s=Console.ReadLine();
            while(s.Length > 0)
            {
                Console.Write(s[0]+" = ");
                int count = 0;
                for(int i=0;i<s.Length;i++)
                {
                    if (s[0] == s[i])
                    {
                        count++;

                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(),String.Empty);
            }
        }
        public static void test()
        {
            Console.WriteLine("enter a str");
            string s = Console.ReadLine();
            while( s.Length > 0)
            {
                Console.WriteLine(s[0] + "=");
                int count = 0;
                for (int i = 0; i < s.Length; i++) 
                {
                    if (s[0] == s[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s=s.Replace(s[0].ToString(),String.Empty);  
            }
            
        }
        public static void dtbk()
        {
            int i;
            Console.WriteLine("enter a decimal number");
            int n=int.Parse(Console.ReadLine());
            int[] arr = new int[10];
           
                for (i = 0; n > 0; i++)
                {
                    arr[i] = n % 2;
                    n = n / 2;
                    
                }
                for (i =i - 1; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);               
                
                }
        }
        public static void sumof()
        {
            int i, sum = 0, reminder;
            Console.WriteLine("enter digits");
            int n=int.Parse(Console.ReadLine());
            while (n > 0)
            {
                reminder = n % 10;
                sum=sum+reminder;
                n=n / 10;
            }
            Console.WriteLine(sum);
        }
        public static void btbk()
        {
            int i, sum = 0, reminder,Base=1;
            Console.WriteLine("enter digits");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                reminder = n % 10;
                sum = sum + reminder;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

