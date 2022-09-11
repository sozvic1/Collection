using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public static class ExtensionsClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] array = new T[list.Count()];
            int i = 0;
            foreach (var item in list)
            {

                array[i] = item;
                i +=2;
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region First Task 
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 20; i++)
            {
                myList.Add(i * 2);
            }
            Console.WriteLine($"Количество елементов {myList.Count}");
            foreach (var item in myList)
            {
                Console.Write($"{item}, ");
            }
            
            #endregion
            #region SecondTask

            Console.WriteLine();
            int[] arr = myList.GetArray();
            foreach (int t in arr)
                Console.Write("{0}  ", t);

            #endregion
            #region Third            
            Console.WriteLine("Сортировка по алфавиту");
            var list = new SortedList<int, string>();
            list.Add(5, "name");
            list.Add(2, "surname");
            list.Add(1, "lastname");
            list.Add(9, "Alex");
            foreach (var key in list.Keys)
            {
                Console.WriteLine($"Ключ {key} значение {list[key]}");
            }
            Console.WriteLine("Сортировка в обратном порядке");
            var comparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
            //var valuePairs = new SortedList<int, string>(comparer);
            var list2 = new SortedList<int, string>(comparer);
            list2.Add(5, "name");
            list2.Add(2, "surname");
            list2.Add(1, "lastname");
            list2.Add(9, "Alex");
            foreach (var key in list2.Keys)
            {
                Console.WriteLine($"Ключ {key} значение {list[key]}");
            }

            #endregion
        }
    }
    }

