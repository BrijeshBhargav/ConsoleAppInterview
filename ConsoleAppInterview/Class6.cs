using System;


namespace ConsoleAppInterview
{
    internal class Class6
    {
        public static void RightRotation()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("   ---   Array elements   --- ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int temp;
            for (int j = 0; j < n - 1; j++)
            {
                temp = a[0];
                a[0] = a[j + 1];
                a[j + 1] = temp;
            }
            Console.WriteLine("   ---   After Right circular rotation   ---   ");
            foreach (int i in a)
            {       
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }

        public static void tes()
        {

            
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                int i, j;
                for (i = 0; i < n; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (i = 0; i < n; i++)
                {
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (i == j)
                            continue;
                        if (a[j] == a[i])
                            break;
                    }

                    if (n == j)
                    {
                        Console.Write(a[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        public static void Ang()
        {
            Console.Write("Enter Hours : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Enter Minutes : ");
            int m = int.Parse(Console.ReadLine());
            double hd = (h * 30) + (m * 30.0 / 60);
            double md = m * 6;
            double diff = Math.Abs(hd - md);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine($"Angle between {h} hour and {m} minute is {diff} degrees");
        }
        public static void DN()
        {
            int n = int.Parse(Console.ReadLine());
            int temp, a = 0;
            temp = n;
            while (n > 0)
            {
                if (n % 10 == 0)
                {
                    a = 1;
                    break;
                }
                n /= 10;
            }
            if (temp > 0 && a == 1)
            {
                Console.WriteLine("Given Number is a Duke Number");
            }
            else
            {
                Console.WriteLine("Given Number is not a Duke Number");
            }
        }
    
        public static void swap()
        {
            Console.WriteLine("Enter first num");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sec num");
            int m=int.Parse(Console.ReadLine());
            int temp;
            temp = n;
            n = m;
            m = temp;
            Console.WriteLine("After swap 1st num");
            Console.WriteLine("After sawp 2nd num");
        }
        public static void prime()
        {
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for(int i=2;i<=n;i++)
            {
                a++;
            }
            if (a == 1)
                Console.WriteLine("prime");
            else
                Console.WriteLine("not prime");
        }
    }

}

