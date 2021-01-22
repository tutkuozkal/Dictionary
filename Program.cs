using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> KitAp = new Dictionary<string, int>();

            KitAp.Add("Ince Memed", 28);
            KitAp.Add("Gozlerim Gozlerinde", 25);
            KitAp.Add("Hamlet", 30);
            

            Console.WriteLine(KitAp.Count);

            //foreach (var degerler in KitAp)
            //{
            //    Console.WriteLine(degerler);
            //}
        }
        class MyDictionary<T> 
        {
            T[] _array;
            T[] _tempArray;
            public MyDictionary()
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length+1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;
            }
        }
    }
}
