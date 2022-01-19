using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsLibrary
{
    public interface IList
    {
        void AddToBack(int element);
        void AddToFront(int element);
        void AddByIndex(int element, int index);
        void RemoveFromFront();
        void RemoveFromBack();
        void RemoveByIndex(int index);
        void RemoveFromBackMulti(int count);
        void RemoveFromFrontMulti(int count);
        void RemoveByIndexMulti(int count, int index);
        void AddToFrontMulti(int[] array);
        void AddToBackMulti(int[] array);

        int GetLenght();
        int GetValueByIndex(int index);
        int GetFirstIndexByValue(int value);
        void SetElementByIndex(int element, int index);
        void Reverse();
        int GetMaxElement();
        int GetMinElement();
        int GetMaxElementIndex();
        int GetMinElementIndex();
        void SortAsc();
        void SortDesc();
        int RemoveFirstByValue(int value);
        int RemoveAllByValue(int value);
        void AddIListToBack(IList list);
        void AddIListToFront(IList list);
        void AddIListByIndex(IList list, int index);

        public IEnumerator<int> GetEnumerator();
        public int this[int index] { get; set; }
    }
}
