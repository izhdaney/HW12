using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class MyArrayList : IList
    {

        private object[] _myarrayList;

        public MyArrayList()
        {
            _myarrayList = new object[0];
    }

        public int Add(object value)
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

        public void Clear()
        {
            _myarrayList = new object[0];
        }

        public bool Contains(object value)
        {
  
            for (int i = 0; i < Count; i++)
            {
                if (_myarrayList[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return _myarrayList.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < _myarrayList.Length; i++)
            {
                if (_myarrayList[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
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
