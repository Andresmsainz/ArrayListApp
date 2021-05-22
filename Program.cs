using System;
using System.Collections;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List!");

            //Creating
            ArrayList array = new ArrayList();
            ArrayList array2 = new ArrayList();
            //Adding
            array.Add("First");
            array.Add("Second");
            array.Add(3);
            array.Add(4.5d);

            array2.Add("James");
            array2.Add("David");
            array2.Add("Charles");
            array2.Add("Ahmad");


            Console.WriteLine("At first");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");

            array.Insert(2, "Third");
            Console.WriteLine("After insertion");
            
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //Index
            Console.WriteLine("--------");
            Console.WriteLine("Index 1 = " + array[1].ToString());

            //Capacity
            Console.WriteLine("--------");
            Console.WriteLine("Array Current Capacity = " + array.Count);

            //Sorting
            Console.WriteLine("--------");
            array2.Sort();
            Console.WriteLine("After Sorting");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            //Reversing
            Console.WriteLine("--------");
            array2.Reverse();
            Console.WriteLine("After Reversing");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            //Removing
            Console.WriteLine("--------");
            array2.Remove("James");
            Console.WriteLine("After Removing");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

            //Remove All
            Console.WriteLine("--------");
            array2.Clear();
            Console.WriteLine("After Remove All");
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }

 
            array2.Add("David");
            array2.Add("Charles");
            array2.Add("Ahmad");

            //Contains
            Console.WriteLine("--------");
            Console.WriteLine("After Asking for James");
            Console.WriteLine(array2.Contains("James"));
            Console.WriteLine("After Asking for Ahmad");
            Console.WriteLine(array2.Contains("Ahmad"));
            //Get Range
            Console.WriteLine("--------");
            ArrayList names = new ArrayList();
            Console.WriteLine("After copying GetRange from array2");
            names = array2.GetRange(0, 2);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
