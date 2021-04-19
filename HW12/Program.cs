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

            arr.Clear();

            foreach (var o in arr)
            {
                Console.Write("{0}\t", o);
            }

            Console.WriteLine(arr.Add(6));
            Console.WriteLine(arr.Add(5));
            Console.WriteLine(arr.Add(8));

            Console.WriteLine(arr.Contains(5));
            Console.WriteLine(arr.Contains(4));



            MyArrayList myArrayList = new MyArrayList();

            Console.WriteLine("\n My Collection\n");

            //Console.WriteLine(myArrayList.Count);
            //Console.WriteLine(myArrayList.IsFixedSize);
            //Console.WriteLine(myArrayList.IsReadOnly);
            //Console.WriteLine(myArrayList.IsSynchronized);
            //Console.WriteLine(myArrayList.SyncRoot);


            //Console.WriteLine(myArrayList.Add(6));
            //Console.WriteLine(myArrayList.Add(5));
            //Console.WriteLine(myArrayList.Add(8));



            //Console.WriteLine(myArrayList.GetEnumerator());

            myArrayList.Clear();

            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }


            Console.WriteLine(myArrayList.Add(6));
            Console.WriteLine(myArrayList.Add(5));
            Console.WriteLine(myArrayList.Add(8));

            Console.WriteLine(myArrayList.Contains(5));
            Console.WriteLine(myArrayList.Contains(4));

            Console.WriteLine(myArrayList.IndexOf(6));

            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }
        }
    }
}
