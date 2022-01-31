using ListsLibrary;
using NUnit.Framework;
using System;

namespace ListsTests
{
    public class Tests
    {
        IList _list;

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void AddToBack_WhenCalled_ShouldAddElementToBack()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5});

            _list.Add(10, _list.Lenght);

            Assert.AreEqual(_list[5], 10);
            Assert.AreEqual(_list[0], 1);
        }

        [Test]
        public void AddToFront_WhenCalled_ShouldAddElementToFront()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(10, 0);

            Assert.AreEqual(_list[0], 10);
          //  Assert.AreEqual(_list[1], 1);
        }

        [Test]
        public void AddByIndex_WhenCalled_ShouldAddElementByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(10, 3);

            Assert.AreEqual(_list[3], 10);
            Assert.AreEqual(_list[0], 1);
            Assert.AreEqual(_list[5], 5);
        }

        [Test]
        public void AddByIndex_WhenCalledWithFirstIndex_ShouldAddElementByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(10, 3);

            Assert.AreEqual(_list[3], 10);
        }

        [Test]
        public void AddByIndex_WhenCalledWithLastIndex_ShouldAddElementByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list[3] = 10;

            Assert.AreEqual(_list[3], 10);
        }

        [Test]
        public void AddByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list[_list.Lenght + 1] = 10;
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void AddByIndex_WhenCalledWithIndexLessThenZero_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list[-1] = 10;
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveFromBack_WhenCalled_ShouldRemoveElementFromBack()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(1, _list.Lenght - 1);

            Assert.AreEqual(_list.Lenght, 4);
        }

        [Test]
        public void RemoveFromFront_WhenCalled_ShouldRemoveElementFromFront()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(1, 0);

            Assert.AreEqual(_list[0], 2);
            Assert.AreEqual(_list.Lenght, 4);
        }
        
        [Test]
        public void RemoveByIndex_WhenCalled_ShouldRemoveElementByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(1, 3);

            Assert.AreEqual(_list[3], 5);
            Assert.AreEqual(_list.Lenght, 4);
        }

        [Test]
        public void RemoveByIndex_WhenCalledWithFirstIndex_ShouldRemoveElementByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(1, 0);

            Assert.AreEqual(_list[0], 2);
            Assert.AreEqual(_list.Lenght, 4);
        }
        [Test]
        public void RemoveByIndex_WhenCalledWithLastIndex_ShouldRemoveElementByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(1, _list.Lenght - 1);

            Assert.AreEqual(_list.Lenght, 4);
        }

        [Test]
        public void RemoveByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(1, _list.Lenght + 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndex_WhenCalledWithIndexLessThanZero_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(1, -1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalled_ShouldRemoveElementsFromBack()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(2, _list.Lenght - 3);

            Assert.AreEqual(_list[2], 5);
            Assert.AreEqual(_list.Lenght, 3);
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalledWith0Count_ShouldNotRemoveElements()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(0, _list.Lenght);

            Assert.AreEqual(_list[4], 5);
            Assert.AreEqual(_list.Lenght, 5);
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalledWithCountMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(10, _list.Lenght - 10);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalledWithIndexLessThenZero_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(3, -1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveFromIndexMulti_WhenCalled_ShouldRemoveElementsFromIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(2, 2);

            Assert.AreEqual(_list[2], 5);
            Assert.AreEqual(_list.Lenght, 3);
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWith0Count_ShouldNotRemoveElements()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Remove(0, 2);

            Assert.AreEqual(_list[2], 3);
            Assert.AreEqual(_list.Lenght, 5);
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithCountMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(5, 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithIndexPlusCountMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(5, 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithCountLessThenZero_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(-2, 2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(2, _list.Lenght + 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithIndexLessThenZero_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                _list.Remove(2, -2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void AddToFrontMulti_WhenCalled_ShouldAddElementsToFront()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(new int[] { 10, 100, 1000 }, 0);

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[2], 1000);
            Assert.AreEqual(_list.Lenght, 8);
        }

        [Test]
        public void AddToFrontMulti_WhenCalledWithOneElement_ShouldAddOneElementToFront()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(new int[] { 10 }, 0);

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[1], 1);
            Assert.AreEqual(_list.Lenght, 6);
        }


        [Test]
        public void AddToFrontMulti_WhenCalledWithNoElements_ShouldNotAddElements()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(new int[] { }, 0);

            Assert.AreEqual(_list[0], 1);
            Assert.AreEqual(_list.Lenght, 5);
        }

        [Test]
        public void AddToBackMulti_WhenCalled_ShouldAddElementsToBack()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(new int[] { 10, 100, 1000 }, _list.Lenght);

            Assert.AreEqual(_list[5], 10);
            Assert.AreEqual(_list[7], 1000);
            Assert.AreEqual(_list.Lenght, 8);
        }

        [Test]
        public void AddToBackMulti_WhenCalledWithOneElement_ShouldAddOneElementsToBack()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(new int[] { 10 }, _list.Lenght);

            Assert.AreEqual(_list[5], 10);
            Assert.AreEqual(_list.Lenght, 6);
        }

        [Test]
        public void AddToBackMulti_WhenCalledWithNoElements_ShouldNotAddElements()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Add(new int[] { }, _list.Lenght);

            Assert.AreEqual(_list[0], 1);
            Assert.AreEqual(_list.Lenght, 5);
        }

        [Test]
        public void AddIListToFront_WhenCalled_ShouldAddIListToFront()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            _list.Add(arrayadd, 0);

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[2], 1000);
            Assert.AreEqual(_list.Lenght, 8);
        }

        [Test]
        public void AddIListToBack_WhenCalled_ShouldAddIListToBack()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            _list.Add(arrayadd, _list.Lenght);

            Assert.AreEqual(_list[5], 10);
            Assert.AreEqual(_list[7], 1000);
            Assert.AreEqual(_list.Lenght, 8);
        }

        [Test]
        public void AddIListByIndex_WhenCalled_ShouldAddIListByIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            _list.Add(arrayadd, 3);

            Assert.AreEqual(_list[3], 10);
            Assert.AreEqual(_list[5], 1000);
            Assert.AreEqual(_list.Lenght, 8);
        }

        [Test]
        public void AddIListByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            try
            {
                _list.Add(arrayadd, 100);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void AddIListByIndex_WhenCalledWithIndexLessThanZeroLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            try
            {
                _list.Add(arrayadd, -1);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetLenght_WhenCalled_ShouldReturnValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(_list.Lenght, 5);
        }

        [Test]
        public void GetValueByIndex_WhenCalled_ShouldReturnValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(_list[4], 5);
        }

        [Test]
        public void GetValueByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                int value = _list[_list.Lenght + 1];
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetValueByIndex_WhenCalledWithIndexLessThenZero_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                int value = _list[-1];
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetFirstIndexByValue_WhenCalled_ShouldReturnIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(_list.FindFirst(3), 2);
        }

        [Test]
        public void GetFirstIndexByValue_WhenCalledWithMissingValue_ShouldThrowException()
        {
            {
                _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

                try
                {
                    int value = _list.FindFirst(100);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void SetElementByIndex_WhenCalled_ShouldSetValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list[0] = 10;
            _list[2] = 100;
            _list[4] = 1000;


            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[2], 100);
            Assert.AreEqual(_list[4], 1000);
        }

        [Test]
        public void SetElementByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            {
                try
                {
                    _list[_list.Lenght + 1] = 10;
                }
                catch (IndexOutOfRangeException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void SetElementByIndex_WhenCalledWithIndexLessThanZeroLenght_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            {
                try
                {
                    _list[-1] = 10;
                }
                catch (IndexOutOfRangeException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void Reverse_WhenCalled_ShouldReverse()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Reverse();

            Assert.AreEqual(_list[0], 5);
            Assert.AreEqual(_list[4], 1);
        }

        [Test]
        public void GetMaxElement_WhenCalled_ShouldReturnValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });


        }

        [Test]
        public void GetMaxElement_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            _list = new ArrayList(new int[] { });

            try
            {
                int value = _list.Max;
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetMinElement_WhenCalled_ShouldReturnValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(_list.Min, 1);
        }

        [Test]
        public void GetMinElement_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            _list = new ArrayList(new int[] { });

            try
            {
                int value = _list.Min;
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetMaxElementIndex_WhenCalled_ShouldReturnValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(_list.MaxElementIndex, 4);
        }

        [Test]
        public void GetMaxElementIndex_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            _list = new ArrayList(new int[] { });

            try
            {
                int value = _list.MaxElementIndex;
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void GetMinElementIndex_WhenCalled_ShouldReturnValue()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(_list.MinElementIndex, 0);
        }

        [Test]
        public void GetMinElementIndex_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            _list = new ArrayList(new int[] { });

            try
            {
                int value = _list.MinElementIndex;
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void SortAsc_WhenCalled_ShouldSort()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Sort();

            for (int i = 0; i < _list.Lenght - 1 ; i++)
            {
                Assert.IsTrue(_list[i] < _list[i + 1]);
            }
        }

        [Test]
        public void SortDesc_WhenCalled_ShouldSort()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            _list.Sort(false);

            for (int i = 0; i < _list.Lenght - 1; i++)
            {
                Assert.IsTrue(_list[i] > _list[i + 1]);
            }
        }

        [Test]
        public void RemoveFirstByValue_WhenCalled_ShouldReturnIndex()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            int i = _list.RemoveFirstByValue(3);

            Assert.AreEqual(i, 2);
            Assert.AreEqual(_list[2], 4);
            Assert.AreEqual(_list.Lenght, 4);
        }

        [Test]
        public void RemoveFirstByValue_WhenCalledWithMissingValue_ShouldThrowException()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            try
            {
                int i = _list.RemoveFirstByValue(100);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveAllByValue_WhenCalled_ShouldReturnCount()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 2 });

            int count = _list.RemoveAllByValue(2);

            Assert.AreEqual(count, 2);
            Assert.AreEqual(_list[1], 3);
            Assert.AreEqual(_list.Lenght, 3);
        }

        [Test]
        public void RemoveAllByValue_WhenCalledWithMissingValue_ShouldReturncount()
        {
            _list = new ArrayList(new[] { 1, 2, 3, 4, 5 });

            int count = _list.RemoveAllByValue(100);

            Assert.AreEqual(count, 0);
            Assert.AreEqual(_list.Lenght, 5);
        }

        
    }
}