using System;
using System.Collections;
using System.Collections.Generic;

namespace ListsLibrary
{
    public partial class ArrayList :  IList, IEnumerable<int>, IEquatable<IList>

    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void Resize(int newSize)
        {
            int[] arrayNew = new int[newSize];
            {
                for (int i = 0; i < ((newSize > Capacity) ? Capacity : newSize); i++)
                {
                    arrayNew[i] = _array[i];
                }
            }

            _array = arrayNew;
            _currentCount = _array.Length;
        }

    }
}
