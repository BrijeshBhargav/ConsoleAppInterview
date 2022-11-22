using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class7
    {
        public static void DN()
        {
          
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, t = n;
            string s = n.ToString(); 
            int l = s.Length; 
            while (t > 0)
            {
                rem = t % 10;
                sum = sum + (int)Math.Pow(rem, l);
                l--;
                t /= 10;
            }
            if (sum == n) 
                Console.WriteLine("Disarium Number"); 
            else
                Console.WriteLine("Not Disarium number");


        }
        public static void StrongNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, f, temp;
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                f = 1;
                for (int i = 1; i <= rem; i++)
                {
                    f *= i;
                }
                sum += f;
                n /= 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Strong number");
            }
            else
            {
                Console.WriteLine("Not Strong number");
            }
        }
        public static void TwistedPrime()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, rem, a = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n /= 10;
            }
           
            for (int i = 2; i <= sum / 2; i++)
            {
                if (sum % i == 0)
                {
                    a = 1;
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Twisted Prime Number");
            }
            else
            {
                Console.WriteLine("Not Twisted Prime Number");
            }
        }
        public static void BuzzNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 10 == 7 || n % 7 == 0)
            {
                Console.WriteLine("Buzz Number");
            }
            else
            {
                Console.WriteLine("Not Buzz Number");
            }
        }
        public static void KaprekarNumber()
        {
            int n = int.Parse(Console.ReadLine());
            int temp, sum = 0, sq, d = 0;
            sq = n * n;
            temp = sq;
            while (sq > 0)
            {
                d++;
                sq /= 10;
            }
            int k = (int)Math.Pow(10, (d / 2));
            while (temp > 0)
            {
                sum = sum + (temp % k);
                temp = temp / k;
            }
            if (sum == n)
            {
                Console.WriteLine(" Kaprekar Number");
            }
            else
            {
                Console.WriteLine("Not Kaprekar Number");
            }



        }

    }
}
