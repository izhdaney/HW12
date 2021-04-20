using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class MyArrayList : IList, ISortMyArray
    {

        private object[] _myarrayList;


        public MyArrayList()
        {
            _myarrayList = new object[0];
        }

        public int Add(object value)
        {
            if (IsFixedSize && IsReadOnly)
            {
                throw new NotSupportedException();
            }
            else
            {
                object[] tmp = new object[_myarrayList.Length + 1];
                for (int i = 0; i < _myarrayList.Length; i++)
                {
                    tmp[i] = _myarrayList[i];
                }

                tmp[tmp.Length - 1] = value;

                _myarrayList = tmp;

                return tmp.Length - 1;
            }

        }

        public void Clear()
        {
            if (IsFixedSize && IsReadOnly)
            {
                throw new NotSupportedException();
            }
            else
            {
                _myarrayList = new object[0];
            }
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < _myarrayList.Length; i++)
            {
                if (_myarrayList[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
                for (int i = 0; i < _myarrayList.Length; i++)
                {
                    array.SetValue(_myarrayList[i], index++);
                }
        }

        public IEnumerator GetEnumerator()
        {
            return _myarrayList.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < _myarrayList.Length; i++)
            {
                if (_myarrayList[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((index < 0) && (index > _myarrayList.Length))
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (IsFixedSize && IsReadOnly)
            {
                throw new NotSupportedException();
            }
            else
            {
                object[] tmp = new object[_myarrayList.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    tmp[i] = _myarrayList[i];
                }

                tmp[index] = value;

                for (int i = index; i < _myarrayList.Length; i++)
                {
                    tmp[i + 1] = _myarrayList[i];
                }
                _myarrayList = tmp;
            }
        }

        public void Remove(object value)
        {
            if (IsFixedSize && IsReadOnly)
            {
                throw new NotSupportedException();
            }
            else
            {
                RemoveAt(IndexOf(value));
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _myarrayList.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (IsFixedSize && IsReadOnly)
            {
                throw new NotSupportedException();
            }
            else
            {
                object[] tmp = new object[_myarrayList.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    tmp[i] = _myarrayList[i];
                }

                for (int i = index + 1; i < _myarrayList.Length; i++)
                {
                    tmp[i - 1] = _myarrayList[i];
                }
                _myarrayList = tmp;
            }
        }

        public void SortBubbleLowToHigh()
        {
            object temp;
            for (int i = 0; i < _myarrayList.Length; i++)
            {
                for (int j = i + 1; j < _myarrayList.Length; j++)
                {
                    if ((double)_myarrayList[i] > (double)_myarrayList[j])
                    {
                        temp = _myarrayList[i];
                        _myarrayList[i] = _myarrayList[j];
                        _myarrayList[j] = temp;
                    }
                }
            }
        }

        public void SortBubbleHighToLow()
        {
            object temp;
            for (int i = 0; i < _myarrayList.Length; i++)
            {
                for (int j = i + 1; j < _myarrayList.Length; j++)
                {
                    if ((int)_myarrayList[i] < (int)_myarrayList[j])
                    {
                        temp = _myarrayList[i];
                        _myarrayList[i] = _myarrayList[j];
                        _myarrayList[j] = temp;
                    }
                }
            }
        }

        public void Reverse()
        {
            if (IsFixedSize && IsReadOnly)
            {
                throw new NotSupportedException();
            }
            else
            {
                object temp;
                for (int i = 0; i < _myarrayList.Length / 2; i++)
                {
                    temp = _myarrayList[i];
                    _myarrayList[i] = _myarrayList[_myarrayList.Length - i - 1];
                    _myarrayList[_myarrayList.Length - i - 1] = temp;
                }
            }
        }

        public object this[int index]
        {
            get
            {
                return _myarrayList[index];
            }
            set
            {
                _myarrayList[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int Count 
        { 
            get { return _myarrayList.Length; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }
    }
}
