using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class4
    {
       public static void tes()
       {
            int i, n;
            int[] a = new int[10];   
            Console.WriteLine("enter a num");
            n=int.Parse(Console.ReadLine());
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            
            }
            Console.WriteLine("decimal val:");
            for (i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
       }
        public static void tes2()
        {
            int n, rem, sum = 0,b=1;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("binary val is");
            while(n>0)
            {
                rem = n % 10;
                sum=sum+rem*b;
                b = b * 2;
                n = n / 10; 
            }
            Console.WriteLine(sum);
        }
        public static void tes3()
        {
            int n,i;
            int[] a=new int[10];    
            Console.WriteLine("enter num");
            n=int.Parse(Console.ReadLine());    
            for( i=0;n>0; i++)
            {
                a[i]=n % 2;
                n = n / 2;
                
            }

           for(i=i-1;i>=0;i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
        }
        public static void charr()
        {
            Console.WriteLine("enter string");
            string s= Console.ReadLine();   
            while(s.Length>0)
            {
                Console.WriteLine(s[0] + "=");
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
        public static void rev()
        {
           string s=string.Empty,r=string.Empty;    
            Console.WriteLine("enter any name");
            s=Console.ReadLine();
            for(int i=s.Length-1;i>=0;i--)
            {
                r += s[i];
            }
            Console.WriteLine(r);
        }
        public static void dec()
        {
            Console.WriteLine("enter name");
            string s =Console.ReadLine();   
            while(s.Length>=0)
            {
                Console.WriteLine(s[0] + "=");
                int count = 0;
                for(int i=0;i<s.Length;i++)
                {
                    if(s[0] == s[i])
                    {
                        count++;
                    }

                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(),String.Empty);
            }
        }
        
    }
}
