﻿using System;
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
            Console.WriteLine(arr.Add("test"));

            arr.Insert(1, "test");



            foreach (var o in arr)
            {
                Console.Write("{0}\t", o);
            }

            //int[] vs = new int[9];
            //Array array = vs;

            //arr.CopyTo(array, 2);



            MyArrayList myArrayList = new MyArrayList();

            Console.WriteLine("\n My Collection\n");

            Console.WriteLine(myArrayList.Add(9));
            Console.WriteLine(myArrayList.Add(8));
            Console.WriteLine(myArrayList.Add(5));
            Console.WriteLine(myArrayList.Add(16));



            int[] myArr = new int[8] { 1, 1, 1, 1, 1, 1, 1, 1 };
            Array array = myArr;


            //myArrayList.CopyTo(array, 2);


            //foreach (var el in myArr)
            //{
            //    Console.Write($"{el}\t");
            //}

            //Console.WriteLine();





            try
            {
                myArrayList.Insert(3, "test");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Значение параметра index меньше нуля.- или - Значение index больше значения Count.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Объект ArrayList доступен только для чтения.- или - ArrayList имеет фиксированный размер.");
            }
            finally
            {

            }

            foreach (var o in myArrayList)
            {
                Console.Write("{0}\t", o);
            }



            //foreach (var o in myArrayList)
            //{
            //    Console.Write("{0}\t", o);
            //}

            //foreach (var o in myArrayList)
            //{
            //    Console.Write("{0}\t", o);
            //}

            //Console.WriteLine();

            //myArrayList.SortBubbleHighToLow();

            //foreach (var o in myArrayList)
            //{
            //    Console.Write("{0}\t", o);
            //}

            //Console.WriteLine();

            //myArrayList.SortBubbleLowToHigh();

            //foreach (var o in myArrayList)
            //{
            //    Console.Write("{0}\t", o);
            //}

            //Console.WriteLine();

        }
    }
}
