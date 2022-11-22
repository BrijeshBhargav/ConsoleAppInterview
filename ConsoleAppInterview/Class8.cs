using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class8
    {
        public static void sum()
        {
            Console.WriteLine("Enter a number");
            int n= int.Parse(Console.ReadLine());
            int sum = 0,rem;
            while(n>0)
            {
                rem = n % 10;
                sum= sum +rem;  
                n= n / 10;  
            }
            Console.WriteLine(sum); 
        }
        public static void btd()
        {
            Console.WriteLine("Enter a number");
            int n= int.Parse(Console.ReadLine()) ;  
            int sum=0,rem,b=1 ,a=n;
            while(n>0)
            {
                rem = n % 10;
                sum = sum +rem*b;
                n = n / 10;
                b = b * 2;
            }
            Console.WriteLine($"Decimal num of {a} is {sum}");
        }
        public static void dtb()
        {
            Console.WriteLine("Enter a num");
            int n=int.Parse(Console.ReadLine()) ;
            int[] a= new int[n];
            int i;
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            for(i=i-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
        public static void charoc()
        {

            Console.Write("Enter a string : ");
            string s = Console.ReadLine();
            while (s.Length > 0)
            {
                Console.Write(s[0] + " = ");
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[0] == s[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(), String.Empty);
            }
        }
        public static void rev()
        {
            Console.WriteLine("enter string");
            string s= string.Empty,r=string.Empty;
            s=Console.ReadLine();

            for(int i = s.Length - 1; i >= 0; i--)
            {
                r += s[i];
            }
            Console.WriteLine(r);
        }
        public static void dup()
        {
            string str=Console.ReadLine();
            string s = string.Empty;
            for(int i=0;i<str.Length;i++)
            {
                if (!s.Contains(str[i]))
                {
                    s+=str[i];
                }               
            }
            Console.WriteLine(s);
        }
        public static void sub()
        {
            string s= Console.ReadLine();
            for(int i=0;i<s.Length;i++)
            {
                StringBuilder a=new StringBuilder();
                for(int j=i;j<s.Length;j++)
                {
                    a.Append(s[j]); 
                }
                Console.WriteLine(a);
            }
        }
        public static void res()
        {
            string s = Console.ReadLine();
            string r = string.Join("",s.Split().Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(r);
        }
        public static void duck()
        {
            Console.WriteLine("enter a num");
            int n=int.Parse(Console.ReadLine());
            int temp,a=0;
            temp = n;
            while(n>0)
            {
                if(n%10==0)
                {
                    a = 1;
                    break;
                }
                n=n/10; 
            }
            if(temp==n)
            {
                Console.WriteLine("duck");
            }
            else
            {
                Console.WriteLine("no duck");
            }

        }
        public static void Angle()
        {
            Console.WriteLine("enter hours");
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            int m=int.Parse(Console.ReadLine());    
            double hd=(h*30)+(m*30.0/60);
            double md = (m * 6);
            double diff =Math.Abs(hd-md);
            if(diff>180)
            {
                diff = 360 - diff;

            }
            Console.WriteLine(diff);

        }
        public static void Right()
        {
            Console.WriteLine("enter a num");
            int n= int.Parse(Console.ReadLine());
            int[] a= new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Array elements");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            int temp;
           for(int j=0;j<n-1;j++)
            {
                temp = a[j];
                a[j]=a[j+1];    
                a[j+1]=temp;    
            }
            Console.WriteLine("After right  rotation");
            foreach (int i in a)
            {
                Console.WriteLine(i +" ");   
            }


        }
        public static void swap()
        {
            Console.WriteLine("enter 1st num");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            int b=int.Parse(Console.ReadLine());
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap 1st val" +a);
            Console.WriteLine("after swap 2nd val" +b);
        }
        public static void Fib()
        {
            Console.WriteLine("fib");
            int a = 0, b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c=a+b;
            Console.WriteLine(c);
            while(c<50)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(c);
            }
        }
        public static void prime()
        {
            Console.WriteLine("enter a num");
            int n= int.Parse(Console.ReadLine());
            int a = 0;
            for(int i=2;i<=n;i++)
            {
                a++;
            }
            if(a==1)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
        public static void palindrome()
        {
            Console.WriteLine("enter a num");
            int n=int.Parse(Console.ReadLine());
            string s=n.ToString();
            int l = s.Length;   
            int sum = 0,rem,a=n;
            while(n>0)
            {
                rem = n % 10;
                n = n / 10;
                sum=sum+(int)Math.Pow(rem,l);    
            }
            if (sum == a)
                Console.WriteLine("amstrong");
            else Console.WriteLine("not amstrong");
        }
        public static void Duplicates()
        {
            int n= int.Parse(Console.ReadLine());
            string S = n.ToString();
            string r = string.Empty;
            for (int i = 0; i < S.Length; i++)
            {
                if (!r.Contains(S[i]))
                {
                    r += S[i];
                }
            }
            Console.WriteLine(r);
            Console.ReadKey();
        }
        public static void dup2()
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            string s= n.ToString(); 
            string r = string.Empty;
            for(int i=0;i<s.Length; i++)
            {
                if(!r.Contains(s[i]))
                {
                    r = r + s[i];
                }

            }
            Console.WriteLine(r);
        }
        public static void sub2()
        {
            Console.WriteLine("enter string");
            string s= Console.ReadLine();
            string r= string.Empty; 
            for(int i=0;i<s.Length;i++)
            {
                StringBuilder a = new StringBuilder();
                for(int j=0;j<s.Length;j++)
                {
                   a.Append(s[j]);
                  
                }
                Console.WriteLine(a);
            }
        }
        public static void prime2()
        {
           Console.WriteLine("ter num");
            int n= int.Parse(Console.ReadLine());
            int a = 0,b=0,sum=0,rem,t=n;
            while(n>0)
            {
                rem = n % 10;
                sum=sum*10+rem;
                n = n / 10;
            }
            for(int i=2;i<=sum;i++)
            {
                if(sum%i==0)
                {
                    a++;
                }
            }
            for (int j = 2; j <= t; j++)
            {
                if (t%j == 0)
                {
                    b++;
                }
            }
            if (a==b)
            {
                Console.WriteLine("twisted");

            }
            else
            {
                Console.WriteLine("no twisted");
            }
          
        }
        public static void AreaofRectange()
        {
            Console.Write("Enter Length : ");
            double l = int.Parse(Console.ReadLine());
            Console.Write("Enter Width : ");
            double w = int.Parse(Console.ReadLine());
            double a = l * w;
            Console.WriteLine("Area of Rectangle : " + a);
        }
        public static void AreaofSquare()
        {
            Console.Write("Enter square : ");
            int s = int.Parse(Console.ReadLine());
            int a = s * s;
            Console.WriteLine("Area of square : " + a);
        }
        public static void AreaofTriangle()
        {
            Console.Write("Enter Height: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Base : ");
            int b = int.Parse(Console.ReadLine());
            int a = (1 / 2) * b * h;
            Console.WriteLine("Area of Traingle : " + a);
        }
        public static void AreaofCircle()
        {
            Console.Write("Enter radius: ");
            int r = int.Parse(Console.ReadLine());
            double a = 3.141 * (r * r);
            Console.WriteLine("Area of Circle : " + a);
        }
        public static void SurfaceAreaofCube()
        {
            Console.Write("Enter the Number of Rows : ");
            int Rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the Number of Columns : ");
            int Columns = int.Parse(Console.ReadLine());
            //Creating a 1d Array 
            Console.WriteLine("Enter the 1D Array Elements : ");
            int[] oneDimensionalArray = new int[Rows * Columns];
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                oneDimensionalArray[i] = int.Parse(Console.ReadLine());
            }

            //Creating 2d Array
            int index = 0;
            int[,] twoDimensionalArray = new int[Rows, Columns];

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    twoDimensionalArray[x, y] = oneDimensionalArray[index];
                    index++;
                }
            }
            //Printing the 2D array elements
            Console.WriteLine("2D Array Elements : ");
            foreach (int item in twoDimensionalArray)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }

}
