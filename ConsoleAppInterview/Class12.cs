using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterview
{
    internal class Class12
    {
        public static void test()
        {
            var obj = new List<int>();
            List<string> names = new List<string>();
            obj.Add(1);
            obj.Add(2);
            obj.Add(2);
            obj.Add(3);
            obj.Remove(1);  
            names.Add("a"); 
            names.Add("b");
            foreach (int items in obj)
            {
                Console.WriteLine(items);
            }
            foreach (var items in names)
            {
                Console.WriteLine(items);
            }
        }
        public static void Hash()
        {
            var obj =new HashSet<int>();
            
            obj.Add(1);
            obj.Add(1);
            obj.Add(2);
            obj.Add(2);
            obj.Add(3);
            obj.Contains(1);
            foreach (var items in obj)
            {
                Console.WriteLine(items);
            }
            var obj2 = new HashSet<string>();
            obj2.Add("brijesh");
            obj2.Add("brijesh");
            obj2.Add("bhargav");
            foreach(var item in obj2)
            {
                Console.WriteLine(item);
            }
        }
        public static void sort()
        {
            var obj=new SortedSet<int>();
            obj.Add(1000);
            obj.Add(100);
            obj.Add(2);
            obj.Add(2);
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            var obj2=new SortedSet<string>();
            obj2.Add("Brijesh");
            obj2.Add("zafer");
            obj2.Add("anif");
            foreach(var item in obj2)
            {
                Console.WriteLine(item);
            }
        }
        public static void stack()
        {
            var obj =new Stack<int>();
            obj.Push(10);
            obj.Push(2);
            obj.Push(3);
            obj.Pop();
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
        }
        public static void Queue()
        {
            var obj = new Queue<int>(); 
            obj.Enqueue(10);
            obj.Enqueue(7);
            obj.Enqueue(9);
            obj.Enqueue(8);
            obj.Dequeue();
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

    }
}
