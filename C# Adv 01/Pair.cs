
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class Pair<Tkey , Tavlue>
    {
        private Tkey key;
        private Tavlue value;
        Array list[] = new Array();
        public void addPair(Tkey k, Tavlue v)
        {
            key = k;
            value = v;
        }
      public void check()
        {
            if (Equals(key, value))
            {
                Console.WriteLine("the key and value are the same");
            }
            else
            {
                Console.WriteLine("the key and value are not the same");
            }
    }
}
