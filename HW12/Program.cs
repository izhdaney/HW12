using System;
using System.Collections;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            Console.WriteLine(arr.Count);
            Console.WriteLine(arr.IsFixedSize);
            Console.WriteLine(arr.IsReadOnly);
            Console.WriteLine(arr.IsSynchronized);
            Console.WriteLine(arr.SyncRoot);

            Console.WriteLine(arr.Add(6));
            Console.WriteLine(arr.Add(5));
            Console.WriteLine(arr.Add(8));
            Console.WriteLine(arr.Add(15));           // ADD
            Console.WriteLine(arr.Add(4));
            Console.WriteLine(arr.Add(1));
            Console.WriteLine(arr.Add(256));



            Console.WriteLine($"Contains - 4 - is {arr.Contains(4)}");             // CONTAINS
            Console.WriteLine($"Contains - 47 - is {arr.Contains(47)}");

            int[] arr1 = new int[10];

            arr.CopyTo(arr1, 1);           // COPY-TO

            foreach (var el in arr1)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\nIndexOf - value 15 - is {arr.IndexOf(15)}");

            arr.Insert(5, 18456);           // INSERT


            foreach (var o in arr)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine();

            arr.Remove(1);              // REMOVE (VALUE)

            foreach (var o in arr)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine();

            arr.RemoveAt(2);

            foreach (var o in arr)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine();

            arr.Sort();

            foreach (var o in arr)
            {
                Console.Write("{0}\t", o);
            }






            MyArrayList myArrayList = new MyArrayList();

            Console.WriteLine("\n\n My Collection\n");

            Console.WriteLine(myArrayList.Count);
            Console.WriteLine(myArrayList.IsFixedSize);
            Console.WriteLine(myArrayList.IsReadOnly);
            Console.WriteLine(myArrayList.IsSynchronized);
            Console.WriteLine(myArrayList.SyncRoot);

            Console.WriteLine(myArrayList.Add(6));
            Console.WriteLine(myArrayList.Add(5));
            Console.WriteLine(myArrayList.Add(8));
            Console.WriteLine(myArrayList.Add(15));           // ADD
            Console.WriteLine(myArrayList.Add(4));
            Console.WriteLine(myArrayList.Add(1));
            Console.WriteLine(myArrayList.Add(256));



            Console.WriteLine($"Contains - 4 - is {myArrayList.Contains(4)}");             // CONTAINS
            Console.WriteLine($"Contains - 47 - is {myArrayList.Contains(47)}");

            int[] arr2 = new int[10];

            myArrayList.CopyTo(arr2, 1);           // COPY-TO

            foreach (var el in arr2)
            {
                Console.Write($"{el}\t");
            }

            Console.WriteLine($"\nIndexOf - value 15 - is {myArrayList.IndexOf(15)}");

            myArrayList.Insert(5, 18456);           // INSERT


            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine();

            myArrayList.Remove(1);              // REMOVE (VALUE)

            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine();

            myArrayList.RemoveAt(2);

            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine();

            myArrayList.SortBubbleLowToHigh();

            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }

        }
    }
}
