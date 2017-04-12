using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] customList;
        public T this[int i] { get { return customList[i]; } set { customList[i] = value; } }

        public CustomList()
        {
            customList = new T[0];
        }


        public int Count()
        {
            return length;
        }
    }
}
