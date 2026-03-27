using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class Container
    {
      public void swap<t>(ref t a, ref t b)
        {
            t temp = a; 
            a = b;
            b = temp;
        }
    }

}
