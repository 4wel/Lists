using ListsLibrary;
using System;
using System.Collections.Generic;

namespace ListsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] { 15, 2, 333, 4, 67, 199, 18 });
            ArrayList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            try
            {

                //int i = array.GetLenght();
                //array.AddToFront(10);
                //array.AddToBack(new[] { 4, 5, 6, 7, 8, 9, 10 });
                //array.AddByIndex(777, 18);
                //array.RemoveFromFront();
                //array.RemoveFromBack();
                //array.RemoveByIndex(2);
                //array.RemoveFromBackMulti(3);
                //array.RemoveFromFrontMulti(2);
                //i = array.GetLenght();
                //int i = array.GetValueByIndex(6);
                // int i = array.GetFirstIndexByValue(199);
                // array.SetElementByIndex(200, 2);
                //array.Reverse();
                //int i = array.GetMaxElementIndex();
                //array.SortAsc();
                //array.SortDesc();
                //int i = array.RemoveAllByValue(333);
                // array.AddIListToBack(arrayadd);
                //array.AddIListToFront(arrayadd);
                //array.AddIListByIndex(arrayadd, 100);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Index!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Argument!");
            }

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

        }

    }
}