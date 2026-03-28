using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class SafeList<t>
    {
        private bool _hasValue;
        private t? value;
        public t valueorDefaule() {
            return _hasValue ?value: default;
        }
    }
}
