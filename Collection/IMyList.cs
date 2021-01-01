using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    interface IMyList<T>  
    {
        void Add(T item);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
}
