using System;
using System.Collections.Generic;
using System.Text;

namespace GenericType.Models
{
    class MyList <T>
    {
        T[] _arr;
        private int  _capacity=1;

        public int  Capacity
        {
            get { return _capacity=1; }
            set
            {
                if (value>0)
                {
                    _capacity = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }
        
        
        public int Count { get => _arr.Length; }
        
        
        public MyList(int capacity)
        {
            
            Capacity = capacity;
            _arr = new T[Capacity];
            
        }

        
        public T this[int index] 
        {
            get 
            {
                if (index<_arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set 
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(T value) 
        {
            
            
            Array.Resize(ref _arr,_arr.Length+Capacity);
            _arr[_arr.Length - 1] = value;
        }
        public void Clear() 
        {
            _arr = new T[0];
        }
        public bool Exist(T value) 
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i],value))
                {
                    return true;
                }
                
                
            }
            return false;
        }
        public void Remove(T value) 
        {
            for (int i = IndexOf(value); i < _arr.Length; i++)
            {
                if (i + 1 != _arr.Length)
                {
                    _arr[i] = _arr[i + 1];
                }
                else
                    break;
            }
            Array.Resize(ref _arr, _arr.Length - 1);
            
        }
        public void Reverse() 
        {
            T valueFirst;
            
            for (int i = 0; i <_arr.Length; i++)
            {

                if (i<=_arr.Length/2)
                {
                    valueFirst = _arr[i];
                    _arr[i] = _arr[_arr.Length - 1 - i];
                    _arr[_arr.Length - 1 - i] = valueFirst;   
                }

            }

        }
        public int IndexOf(T value) 
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i],value))
                {
                    return i;

                }
            }
            return -1;
        }
        public int LastIndexOf(T value) 
        {
            int indexOf = -1;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i],value))
                {
                    indexOf = i;
                }

            }
            return indexOf;
        
        }
    }
}
