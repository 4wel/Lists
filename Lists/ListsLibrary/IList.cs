using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLibrary
{
    public interface IList
    {
        int Lenght { get; }
        int Max { get; }
        int Min { get; }
        int MaxElementIndex { get; }
        int MinElementIndex { get; }

        void Add(int element, int index);
        void Add(int[] array, int index);
        void Add(IList list, int index);
        void Remove(int count, int index);
        int FindFirst(int value);
        void Reverse();
        void Sort(bool ascending = true);
        int RemoveFirstByValue(int value);
        int RemoveAllByValue(int value);

        public IEnumerator<int> GetEnumerator();
        public int this[int index] { get; set; }
    }
}
