using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01.Question_11
{
    internal class SubClass<t>: BaseClass<t> where t : BaseClass<t>
    {
    }
}
