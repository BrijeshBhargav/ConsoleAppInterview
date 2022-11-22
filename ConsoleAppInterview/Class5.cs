using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class5
    {
        public static void dup()
        {
            string str = Console.ReadLine();
            string r = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!r.Contains(str[i]))
                {
                    r += str[i];

                }
            }
            Console.WriteLine(r);

        }


        public static void sub2()
        {
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder n = new StringBuilder();
                for (int j = i; j < str.Length; j++)
                {
                    n.Append(str[j]);
                    Console.WriteLine(n);
                }
            }
        }
        public static void strreverse()
        {
            Console.WriteLine("Enter the number of strings");
            int n;
            n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            foreach (string s in str)
            {
                char[] chars = s.ToCharArray();
                Console.WriteLine(s + " Reverse is:" + "----");
                for (int i = chars.Length - 1; i >= 0; i--)
                {
                    Console.Write(chars[i]);

                }
                Console.WriteLine();

            }
        }
        public static void Reversestring()
        {
            string r = string.Empty;
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            for (int j = 0; j < n; j++)
            {
                a[j] = Console.ReadLine();
            }
            //for (int b = 0; b < n; b++)
            //{
            //    Console.Write(a[b] + " ");
            //}
            //Console.WriteLine();
            foreach (string k in a)
            {
                for (int i = k.Length - 1; i >= 0; i--)
                {
                    r += k[i];
                }
                Console.Write(r + " ");
                r = string.Empty;
            }
            Console.WriteLine();
        }
        public static void RES()
        {
            string s = Console.ReadLine();
            string r = string.Join(" ", s.Split().Select(x => new string(x.Reverse().ToArray())));
            Console.WriteLine(r);

        }
        public static void TDOD()
        {
            Console.Write("Enter no of Rows :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter no of Columns :");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[,] b = new int[n, m];
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}] : ", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("two dimensional array :");
            for (int g = 0; g < m; g++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write(b[g, h] + " ");
                }
                Console.WriteLine();
            }
            int i, j, k = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    k = i * m + j;
                    a[k] = b[i, j];
                    k++;
                }
            }
            Console.WriteLine("One dimensional array :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + " ");
            }
            Console.WriteLine();
        }
        public static void ODTT()
        {
            Console.Write("Enter no of Rows :");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter no of Rows :");
            int n = int.Parse(Console.ReadLine());
            int x = m * n;
            int[] a = new int[x];
            for (int i = 0; i < x; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("One dimensional array");
            for (int i = 0; i < x; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            int[,] b = new int[m, n];
            int k, l, z = 0;
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    z = k * m + l;
                    b[k, l] = a[z];
                    z++;

                }
            }
            Console.WriteLine("two dimensional array");
            for (k = 0; k < m; k++)
            {
                for (l = 0; l < n; l++)
                {
                    Console.Write(b[k, l] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void demo()
        {

            Console.Write("Enter no of Rows :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter no of Columns :");
            int m = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            int[,] b = new int[n, m];
            for (int g = 0; g < n; g++)
            {
                for (int h = 0; h < m; h++)
                {
                    Console.Write("Enter values [{0}][{1}] : ", g, h);
                    b[g, h] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("two dimensional array :");
            for (int g = 0; g < m; g++)
            {
                for (int h = 0; h < n; h++)
                {
                    Console.Write(b[g, h] + " ");
                }
                Console.WriteLine();
            }
            int i, j, k = 0;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    k = i * m + j;
                    a[k] = b[i, j];
                    k++;
                }
            }
            Console.WriteLine("One dimensional array :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write((a[i * m + j]) + " ");
            }

        }
        public static void arr()
        {
            Console.WriteLine("enter a row");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a col");
            int col = int.Parse(Console.ReadLine());
            int x = row * col;
            int[] a = new int[x];


            for (int g = 0; g < row; g++)
            {
                a[x] = int.Parse(Console.ReadLine());
            }
            for (int g = 0; g < row; g++)
            {
                Console.WriteLine(a[x] + " ");
            }
        }
        public static void DukeNumber()
        {
            Console.Write("Enter a Number :");
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
                Console.WriteLine(temp + "Given Number is a Duke Number");
            }
            else
            {
                Console.WriteLine(temp + "Given Number is not a Duke Number");
            }
        }
        public static void RemoveDuplicates()
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[50];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("  ---   Array elements   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n;)
                {
                    if (a[j] == a[i])
                    {
                        for (int k = j; k < n; k++)
                        {
                            a[k] = a[k + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            Console.WriteLine(" ---   After Removing Duplicate Values   ---   ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
  
