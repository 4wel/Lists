using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ListsLibrary
{
    public partial class ArrayList : IList, IEnumerable<int>, IEquatable<IList>
    {
        private const int DefaultSize = 4;
        private const double Increment = 1.33;
        private int _currentCount;
        private int[] _array;

        private int DefaultNewSize => (int)(_array.Length * Increment);
        public int Count => _currentCount;
        public int Capacity => _array.Length;

        public int Max
        {
            get
            {
                if (_array.Length == 0 | _array == null)
                {
                    throw new ArgumentNullException();
                }

                int result = _array[0];

                for (int i = 0; i < Count; i++)
                {
                    if (_array[i] > result)
                    {
                        result = _array[i];
                    }
                }

                return result;
            }
        }

        public int Min
        {
            get
            {
                if (_array.Length == 0 | _array == null)
                {
                    throw new ArgumentNullException();
                }

                int result = _array[0];

                for (int i = 0; i < Count; i++)
                {
                    if (_array[i] < result)
                    {
                        result = _array[i];
                    }
                }

                return result;
            }
        }

        public int Lenght
        {
            get => Count;
        }

        public int MaxElementIndex
        {
            get => FindFirst(Max);
        }

        public int MinElementIndex
        {
            get => FindFirst(Min);
        }

        public ArrayList()
        {
            _array = new int[DefaultSize];
        }

        public ArrayList(int capacity)
        {
            _array = new int[capacity];
        }

        public ArrayList(int[] array)
        {
            _array = new int[(int)(array.Length * Increment)];

            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }

            _currentCount = array.Length;
        }

        public void Add(int element, int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            for (int i = Count - 1; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[index] = element;
            ++_currentCount;
        }

        public void Add(int[] array, int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int lenght = array.Length;
            var newSize = Count + array.Length;
            int j = index;
            
            Resize(newSize);

            for (int i = Count - 1; i >= lenght + index; i--)
            {
                _array[i] = _array[i - lenght];
            }

            foreach (int item in array)
            {
                _array[j] =  item;
                ++j;
            }
        }

        public void Add(IList list, int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int lenght = list.Lenght;
            var newSize = Count + list.Lenght;
            int j = index;

            Resize(newSize);

            for (int i = Count - 1; i >= lenght + index; i--)
            {
                _array[i] = _array[i - lenght];
            }

            foreach (int item in list)
            {
                _array[j] = item;
                ++j;
            }
        }

        public void Remove(int count, int index)
        {
            if (count < 0 || index > Count || index < 0 || count > Count || count + index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < Count - count; i++)
            {
                _array[i] = (i < index) ? _array[i] : _array[i + count];
            }

            int newSize = Count - count;

            Resize(newSize);
        }

        public int FindFirst(int value)
        {
            int result = -1;
            
            for (int i = 0; i < Count; i++)
            {
                if (_array[i] == value)
                {
                    result = i;
                    break;
                }
            }
            
            if (result < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        public void Reverse()
        { 
            int[] array = new int[Count];

            for (int i = 0; i < Count; i++)
            {
                array[Count - i - 1] = _array[i];
            }

            _array = array;
        }

        public void Sort(bool ascending = true)
        {
            int[] array = new int[Count];
            int j;

            for (int i = 0; i < array.Length; i++)
            {
                if (ascending == true)
                {
                    j = MinElementIndex;
                }
                else
                {
                    j = MaxElementIndex;
                }

                array[i] = _array[j];
                Remove(1, j);
            }

            Resize(array.Length);
            _array = array;
        }

        public int RemoveFirstByValue(int value)
        {
            int index = FindFirst(value);

            Remove(1, index);

            return index;
        }

        public int RemoveAllByValue(int value)
        {
            int count = 0;

            for (int i = 0; i < Count; i++)
            {
                try
                {
                    i = FindFirst(value);
                    Remove(1, i);
                    count++;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
            
            return count;
        }

        public void AddIListToBack(IList list)
        {
            int lenght = list.Lenght;
            int initialLenght = Count;
            int i = 0;

            Resize(_currentCount + lenght);

            foreach (int item in list)
            {
                _array[initialLenght + i] = item;
                ++i;
            }
        }

        public int this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IList);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals([AllowNull] IList list)
        {
            bool result = true;
            
            if (list != null && list.Lenght == Count)
            {
                for (int i = 0; i < Count; ++i)
                {
                    if (this[i].CompareTo(list[i]) != 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}