using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListProject
{
    public class ArrayTest<T>
    {
        public T[] array = new T[10];
        int index = 0;
        public T this[int index] 
        {
            get { return array[index]; } 
        }
        public bool Add(T item)
        {
            if (index >= 10)
                return false;

            array[index++] = item;
            return true;
        }
        public T Get(int index)
        {
            if (index < this.index && index >= 0)
                return array[index];
            else
                return default(T);
        }
        public int Count()
        {
            return index;
        }
        public IEnumerator<T> GetEnumerator()
        {
            //Выводит весь массив от 0 до 10
            //foreach(T item in array)
            //{
            //    yield return item;
            //}

            //перечисляет лишь то, что заполнено
            return new ArrayTestEnumerator<T>(this);
        }
    }
}
