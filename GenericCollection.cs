using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class GenericCollection<T>
    {
        public GenericCollection()
        {
            _store = Array.Empty<T>();
        }

        private T[] _store;
        public int NumberOfItems { get; private set; }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _store.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _store[index];
            }
        }

        public void Add(T item)
        {
            //create new array that is 1 size larger than the existing array
            var newArray = new T[_store.Length + 1];
            //copy all data from old array to new array
            _store.CopyTo(newArray, 0);
            //take the new item and place at the last index of the new array
            newArray[^1] = item;
            //point the store reference to the new array
            _store = newArray;
            NumberOfItems++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _store.Length)
            {
                throw new IndexOutOfRangeException();
            }
            //create an array that is 1 size smaller than existing array
            var newArray = new T[_store.Length - 1];
            Array.Copy(_store, 0, newArray, 0, index);
            Array.Copy(_store, index + 1, newArray, index, _store.Length - index - 1);

            _store = newArray;
            NumberOfItems--;
        }
    }
}

//6
//1 2 3 4 5
//0 0 0 0 0 0
//1 2 3 4 5 0

//1 2 3 4 5 6 7 4 3 2 3 3 
//0 0 0 0 0 0 0 0 0 0 0

//1 2 3 4 5 6 7 3 2 3 3

//1 2 3 4 5 6 7 0 0 0 0