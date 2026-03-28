using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class Container<T> where T: IComparable<T>
    {
     private T[] values;

        public T findMax(T value) { 
        
            T max = value;
                foreach (T item in values)
                {
                    if (item.CompareTo(max) > 0)
                    {
                        max = item;
                    }
                }
                return max;
        }
    }

}
