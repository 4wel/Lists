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

        public void AddToBack(int element)
        {
            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            _array[_currentCount++] = element;
        }

        public void AddToFront(int element)
        {
            if (Count == Capacity)
            {
                Resize(DefaultNewSize);
            }

            for (int i = Count - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[0] = element;
            ++_currentCount;
        }

        public void AddByIndex(int element, int index)
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

        public void RemoveFromFront()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }

            int newSize = Count - 1;

            Resize(newSize);
        }

        public void RemoveFromBack()
        {
            int newSize = Count - 1;

            Resize(newSize);
        }

        public void RemoveByIndex(int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = 0; i < Count - 1; i++)
            {
                _array[i] = (i < index) ? _array[i] : _array[i + 1];
            }

            int newSize = Count - 1;

            Resize(newSize);
        }

        public void RemoveFromFrontMulti(int count)
        {
            if (count > Count | count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = 0; i < Count - count; i++)
            {
                _array[i] = _array[i + count];
            }

            int newSize = Count - count;

            Resize(newSize);
        }

        public void RemoveFromBackMulti(int count)
        {
            if (count > Count | count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int newSize = Count - count;

            Resize(newSize);
        }

        public void RemoveByIndexMulti(int count, int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (count > Count - index | count < 0 | count > Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < Count - 1; i++)
            {
                _array[i] = _array[i + count];
            } 

            int newSize = Count - count;

            Resize(newSize);
        }

        public void AddToFrontMulti(int[] array)
        {
            int lenght = array.Length;
            int initialLenght = Count;
            var newSize = Count + array.Length;
            int j = 0;

            Resize(newSize);

            for (int i = Count - 1; i >= lenght; i--)
            {
                _array[i] = _array[i - lenght];
            }

            foreach (int item in array)
            {
                _array[j] = item;
                ++j;
            }
        }

        public void AddToBackMulti(int[] array)
        {
            var newSize = Count + array.Length;
            int initialLenght = Count;

            Resize(newSize);

            for (int i = initialLenght, j = 0; i < newSize; i++, j++)
            {
                _array[i] = array[j];
            }
        }

        public int GetLenght()
        {
            return Count;
        }

        public int GetValueByIndex(int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }

        public int GetFirstIndexByValue(int value)
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

        public void SetElementByIndex(int element, int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            _array[index] = element;
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

        public int GetMaxElement()
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

        public int GetMinElement()
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

        public int GetMaxElementIndex()
        {
            if (_array.Length == 0 | _array == null)
            {
                throw new ArgumentNullException();
            }

            int maxElement = _array[0];
            int maxElementIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                if (_array[i] > maxElement)
                {
                    maxElement = _array[i];
                    maxElementIndex = i;
                }
            }

            return maxElementIndex;
        }

        public int GetMinElementIndex()
        {
            if (_array.Length == 0 | _array == null)
            {
                throw new ArgumentNullException();
            }

            int minElement = _array[0];
            int minElementIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                if (_array[i] < minElement)
                {
                    minElement = _array[i];
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        public void SortAsc()
        {
            int min = 0;

            for (int i = 0; i < Count; i++)
            {
                min = i;

                for (int j = i + 1; j < Count; j++)
                {
                    if (_array[min] > _array[j])
                    {
                        min = j;
                    }
                }

                Swap(ref _array[i], ref _array[min]);
            }
        }

        public void SortDesc()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (_array[j] > _array[j - 1])
                    {
                        Swap(ref _array[j], ref _array[j - 1]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public int RemoveFirstByValue(int value)
        {
            int index = -1;

            for (int i = 0; i < Count; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 0; i < Count - 1; i++)
            {
                _array[i] = (i < index) ? _array[i] : _array[i + 1];
            }

            if (index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int newSize = Count - 1;

            Resize(newSize);

            return index;
        }

        public int RemoveAllByValue(int value)
        {
            int index;
            int count = 0;

            for (int i = 0; i < Count; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    count++;

                    for (int j = 0; j < Count - 1; j++)
                    {
                        _array[j] = (j < index) ? _array[j] : _array[j + 1];
                    }

                    int newSize = Count - 1;
                    
                    Resize(newSize);
                }
            }

            return count;
        }

        public void AddIListToBack(IList list)
        {
            int lenght = list.GetLenght();
            int initialLenght = Count;
            int i = 0;

            Resize(_currentCount + lenght);

            foreach (int item in list)
            {
                _array[initialLenght + i] = item;
                ++i;
            }
        }

        public void AddIListToFront(IList list)
        {
            int lenght = list.GetLenght();
            int initialLenght = Count;
            int j = 0;

            Resize(Count + lenght);

            for (int i = Count - 1; i >= lenght; i--)
            {
                _array[i] = _array[i - lenght];
            }

            foreach (int item in list)
            {
                _array[j] = item;
                ++j;
            }
        }

        public void AddIListByIndex(IList list, int index)
        {
            if (index > Count | index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int lenght = list.GetLenght();
            int initialLenght = Count;
            int j = 0;

            Resize(Count + lenght);

            for (int i = Count - 1; i >= index + lenght; i--)
            {
                _array[i] = _array[i - lenght];
            }

            foreach (int item in list)
            {
                _array[j + index] = item;
                ++j;
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
            if (list != null && list.GetLenght() == Count)
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