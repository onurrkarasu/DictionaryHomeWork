using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHomeWork
{
    class MyDictionary<T, V>
    {
        T[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new V[0];
        }

        public void Add(T key, V value)
        {
            T[] tempArrayKeys = keys;
            V[] tempArrayValues = values;
            keys = new T[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                keys[i] = tempArrayKeys[i];
                values[i] = tempArrayValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return values.Length; }

        }
        public V[] Values
        {
            get { return values; }
        }



    }
}
