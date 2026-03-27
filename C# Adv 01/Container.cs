using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class Container<t>
    {
        private t test;
        public void addT(t dt)
        {
         test = dt;
        }
        public t  GetT()
        {
            return test;
        }
    }
}
