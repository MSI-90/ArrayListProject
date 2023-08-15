using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListProject
{
    public class ArrayTestEnumerator<T> : IEnumerator<T>
    {
        int currIndex = -1;
        ArrayTest<T> test;
        public ArrayTestEnumerator(ArrayTest<T> test)
        {
            this.test = test;
        }
        public T Current => test[currIndex];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            currIndex++;
            if (currIndex >= test.Count())
                return false;
            else
                return true;
        }

        public void Reset()
        {
            currIndex = -1;
        }
    }
}
