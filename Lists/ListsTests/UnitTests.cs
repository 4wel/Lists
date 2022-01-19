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
           _list = new ArrayList(new[] { 15, 2, 333, 4, 67, 199, 18 });

        }

        [Test]
        public void AddToBack_WhenCalled_ShouldAddElementToBack()
        {
            _list.AddToBack(10);

            Assert.AreEqual(_list[7], 10);
            Assert.AreEqual(_list[0], 15);
        }

        [Test]
        public void AddToFront_WhenCalled_ShouldAddElementToFront()
        {
            _list.AddToFront(10);

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[7], 18);
        }

        [Test]
        public void AddByIndex_WhenCalled_ShouldAddElementByIndex()
        {
            _list.AddByIndex(10, 3);

            Assert.AreEqual(_list[3], 10);
            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[7], 18);
        }

        [Test]
        public void AddByIndex_WhenCalledWithFirstIndex_ShouldAddElementByIndex()
        {
            _list.AddByIndex(10, 0);

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[1], 15);
            Assert.AreEqual(_list[7], 18);
        }
        [Test]
        public void AddByIndex_WhenCalledWithLastIndex_ShouldAddElementByIndex()
        {
            _list.AddByIndex(10, 6);

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[6], 10);
            Assert.AreEqual(_list[7], 18);
        }

        [Test]
        public void AddByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            try
            {
                _list.AddByIndex(10, 100);
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
            try
            {
                _list.AddByIndex(10, -5);
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
            _list.RemoveFromBack();

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[5], 199);
            Assert.AreEqual(_list.GetLenght(), 6);
        }

        [Test]
        public void RemoveFromFront_WhenCalled_ShouldRemoveElementFromFront()
        {
            _list.RemoveFromFront();

            Assert.AreEqual(_list[0], 2);
            Assert.AreEqual(_list[5], 18);
            Assert.AreEqual(_list.GetLenght(), 6);
        }
        
        [Test]
        public void RemoveByIndex_WhenCalled_ShouldRemoveElementByIndex()
        {
            _list.RemoveByIndex(3);

            Assert.AreEqual(_list[3], 67);
            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[5], 18);
            Assert.AreEqual(_list.GetLenght(), 6);
        }

        [Test]
        public void RemoveByIndex_WhenCalledWithFirstIndex_ShouldRemoveElementByIndex()
        {
            _list.RemoveByIndex(0);

            Assert.AreEqual(_list[0], 2);
            Assert.AreEqual(_list[5], 18);
            Assert.AreEqual(_list.GetLenght(), 6);
        }
        [Test]
        public void RemoveByIndex_WhenCalledWithLastIndex_ShouldRemoveElementByIndex()
        {
            _list.RemoveByIndex(6);

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[5], 199);
        }

        [Test]
        public void RemoveByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            try
            {
                _list.RemoveByIndex(100);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalled_ShouldRemoveElementsFromBack()
        {
            _list.RemoveFromBackMulti(3);

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[3], 4);
            Assert.AreEqual(_list.GetLenght(), 4);
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalledWith0Count_ShouldRemoveElementsFromBack()
        {
            _list.RemoveFromBackMulti(0);

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[6], 18);
            Assert.AreEqual(_list.GetLenght(), 7);
        }

        [Test]
        public void RemoveFromBackMulti_WhenCalledWithCountMoreThanLenght_ShouldThrowException()
        {
            try
            {
                _list.RemoveFromBackMulti(100);
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
            try
            {
                _list.RemoveFromBackMulti(-10);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalled_ShouldRemoveElementsFromBack()
        {
            _list.RemoveByIndexMulti(3, 3);

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[1], 2);
            Assert.AreEqual(_list[2], 333);
            Assert.AreEqual(_list[3], 18);
            Assert.AreEqual(_list.GetLenght(), 4);
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWith0Count_ShouldRemoveElementsFromBack()
        {
            _list.RemoveByIndexMulti(3, 0);

            Assert.AreEqual(_list[0], 4);
            Assert.AreEqual(_list[3], 18);
            Assert.AreEqual(_list.GetLenght(), 4);
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithCountMoreThanLenght_ShouldThrowException()
        {
            try
            {
                _list.RemoveByIndexMulti(100, 0);
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
            try
            {
                _list.RemoveByIndexMulti(3, 5);
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
            try
            {
                _list.RemoveByIndexMulti(-100, 0);
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
            try
            {
                _list.RemoveByIndexMulti(0, 100);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void RemoveByIndexMulti_WhenCalledWithIndexLessThenZero_ShouldThrowException()
        {
            try
            {
                _list.RemoveByIndexMulti(0, -100);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void AddToFrontMulti_WhenCalled_ShouldAddElementsToFront()
        {
            _list.AddToFrontMulti(new int[] { 10, 100, 1000 });

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[2], 1000);
            Assert.AreEqual(_list.GetLenght(), 10);
        }

        [Test]
        public void AddToFrontMulti_WhenCalledWithOneElement_ShouldAddElementsToFront()
        {
            _list.AddToFrontMulti(new int[] { 10 });

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[1], 15);
            Assert.AreEqual(_list.GetLenght(), 8);
        }


        [Test]
        public void AddToFrontMulti_WhenCalledWithNoElements_ShouldAddElementsToFront()
        {
            _list.AddToFrontMulti(new int[] { });

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[6], 18);
            Assert.AreEqual(_list.GetLenght(), 7);
        }

        [Test]
        public void AddToBackMulti_WhenCalled_ShouldAddElementsToBack()
        {
            _list.AddToBackMulti(new int[] { 10, 100, 1000 });

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[7], 10);
            Assert.AreEqual(_list[9], 1000);
            Assert.AreEqual(_list.GetLenght(), 10);
        }

        [Test]
        public void AddToBackMulti_WhenCalledWithOneElement_ShouldAddElementsToBack()
        {
            _list.AddToBackMulti(new int[] { 10 });

            Assert.AreEqual(_list[7], 10);
            Assert.AreEqual(_list.GetLenght(), 8);
        }

        [Test]
        public void AddToBackMulti_WhenCalledWithNoElements_ShouldAddElementsToBack()
        {
            _list.AddToBackMulti(new int[] { });

            Assert.AreEqual(_list[0], 15);
            Assert.AreEqual(_list[6], 18);
            Assert.AreEqual(_list.GetLenght(), 7);
        }

        [Test]
        public void GetLenght_WhenCalled_ShouldReturnValue()
        {
            _list.GetLenght();

             Assert.AreEqual(_list.GetLenght(), 7);
        }

        [Test]
        public void GetValueByIndex_WhenCalled_ShouldReturnValue()
        {
            _list.GetValueByIndex(5);

            Assert.AreEqual(_list[5], 199);
        }

        [Test]
        public void GetValueByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            try
            {
                _list.GetValueByIndex(100);
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
            try
            {
                _list.GetValueByIndex(-1);
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
            int index =_list.GetFirstIndexByValue(199);

            Assert.AreEqual(index, 5);
        }

        [Test]
        public void GetFirstIndexByValue_WhenCalledWithMissingValue_ShouldThrowException()
        {
            {
                try
                {
                    _list.GetFirstIndexByValue(500);
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
            _list.SetElementByIndex(299, 0);
            _list.SetElementByIndex(199, 5);
            _list.SetElementByIndex(399, 6);

            Assert.AreEqual(_list[0], 299);
            Assert.AreEqual(_list[5], 199);
            Assert.AreEqual(_list[6], 399);
        }

        [Test]
        public void SetElementByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            {
                try
                {
                    _list.SetElementByIndex(299, 10);
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
            {
                try
                {
                    _list.SetElementByIndex(299, -10);
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
            _list.Reverse();

            Assert.AreEqual(_list[0], 18);
            Assert.AreEqual(_list[6], 15);
        }

        [Test]
        public void GetMaxElement_WhenCalled_ShouldReturnValue()
        {
            int i =_list.GetMaxElement();

            Assert.AreEqual(i, 333);
        }

        [Test]
        public void GetMaxElement_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            {
                _list.RemoveFromFrontMulti(7);

                try
                {
                    _list.GetMaxElement();
                }
                catch (ArgumentNullException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void GetMinElement_WhenCalled_ShouldReturnValue()
        {
            int i = _list.GetMinElement();

            Assert.AreEqual(i, 2);
        }

        [Test]
        public void GetMinElement_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            {
                _list.RemoveFromFrontMulti(7);

                try
                {
                    _list.GetMinElement();
                }
                catch (ArgumentNullException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void GetMaxElementIndex_WhenCalled_ShouldReturnValue()
        {
            int i = _list.GetMaxElementIndex();

            Assert.AreEqual(i, 2);
        }

        [Test]
        public void GetMaxElementIndex_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            {
                _list.RemoveFromFrontMulti(7);

                try
                {
                    _list.GetMaxElementIndex();
                }
                catch (ArgumentNullException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void GetMinElementIndex_WhenCalled_ShouldReturnValue()
        {
            int i = _list.GetMinElementIndex();

            Assert.AreEqual(i, 1);
        }

        [Test]
        public void GetMinElementIndex_WhenCalledWithEmptyArray_ShouldThrowException()
        {
            {
                _list.RemoveFromFrontMulti(7);

                try
                {
                    _list.GetMinElementIndex();
                }
                catch (ArgumentNullException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void SortAsc_WhenCalled_ShouldSort()
        {
            _list.SortAsc();

            for (int i = 0; i < _list.GetLenght() - 1 ; i++)
            {
                Assert.IsTrue(_list[i] < _list[i + 1]);
            }
        }

        [Test]
        public void SortDesc_WhenCalled_ShouldSort()
        {
            _list.SortDesc();

            for (int i = 0; i < _list.GetLenght() - 1; i++)
            {
                Assert.IsTrue(_list[i] > _list[i + 1]);
            }
        }

        [Test]
        public void RemoveFirstByValue_WhenCalled_ShouldReturnIndex()
        {
            int i = _list.RemoveFirstByValue(333);

            Assert.AreEqual(i, 2);
            Assert.AreEqual(_list[2], 4);
            Assert.AreEqual(_list.GetLenght(), 6);
        }

        [Test]
        public void RemoveFirstByValue_WhenCalledWithMissingValue_ShouldThrowException()
        {
            {
                try
                {
                    int i = _list.RemoveFirstByValue(500);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Assert.Pass();
                }

                Assert.Fail();
            }
        }

        [Test]
        public void RemoveAllByValue_WhenCalled_ShouldReturncount()
        {
            _list.AddByIndex(333, 5);

            int count = _list.RemoveAllByValue(333);

            Assert.AreEqual(count, 2);
            Assert.AreEqual(_list[2], 4);
            Assert.AreEqual(_list[5], 18);
            Assert.AreEqual(_list.GetLenght(), 6);
        }

        [Test]
        public void RemoveAllByValue_WhenCalledWithMissingValue_ShouldReturncount()
        {
            int count = _list.RemoveAllByValue(500);

            Assert.AreEqual(count, 0);
            Assert.AreEqual(_list.GetLenght(), 7);
        }

        [Test]
        public void AddIListToFront_WhenCalled_ShouldAddIListToFront()
        {
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            _list.AddIListToFront(arrayadd);

            Assert.AreEqual(_list[0], 10);
            Assert.AreEqual(_list[2], 1000);
            Assert.AreEqual(_list.GetLenght(), 10);
        }

        [Test]
        public void AddIListToBack_WhenCalled_ShouldAddIListToBack()
        {
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            _list.AddIListToBack(arrayadd);

            Assert.AreEqual(_list[7], 10);
            Assert.AreEqual(_list[9], 1000);
            Assert.AreEqual(_list.GetLenght(), 10);
        }

        [Test]
        public void AddIListByIndex_WhenCalled_ShouldAddIListByIndex()
        {
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            _list.AddIListByIndex(arrayadd, 2);

            Assert.AreEqual(_list[2], 10);
            Assert.AreEqual(_list[4], 1000);
            Assert.AreEqual(_list[9], 18);
            Assert.AreEqual(_list.GetLenght(), 10);
        }

        [Test]
        public void AddIListByIndex_WhenCalledWithIndexMoreThanLenght_ShouldThrowException()
        {
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            try
            {
                _list.AddIListByIndex(arrayadd, 100);
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
            IList arrayadd = new ArrayList(new[] { 10, 100, 1000 });

            try
            {
                _list.AddIListByIndex(arrayadd, -1);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}