using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class MyList<T> : IMyList<T>,IEnumerable<T>, IEnumerator
    {
        T[] arr;
        int position = -1;
        public MyList()
        {
            arr = new T[0];
        }
        public T this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public int Count { get { return arr.Length; } }

        public object Current
        {
            get { return arr[position]; }
        }

        public void Add(T item)
        {
            T[] newArr = new T[arr.Length+1]; 
            arr.CopyTo(newArr, 0);
            newArr[arr.Length] = item;
            arr = newArr;
        }

        public void Clear()
        {
            arr = new T[0];
        }

        public bool Contains(T value)
        {
            if(arr.Length!=0)
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                        return true;
                }
            return false;
        }

        public IEnumerator<T> GetEnumerator()  
        {
            while (true)
            {
                if (position < arr.Length - 1)
                {
                    position++;
                    yield return arr[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }

        bool IEnumerator.MoveNext()
        {          
            if(position<arr.Length-1)
            {
                position++;
                    return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
