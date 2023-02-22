using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class13
    {
        int n;
        int[] arr;
        public  void test()
        {
            n = int.Parse(Console.ReadLine());
            arr= new int[n];    
            for(int i=0;i<n;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
        }
        public void test2()
        {
         SqlConnection conn = null; 

        }
    }
}
