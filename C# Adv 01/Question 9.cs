using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class Question_9<t> where t : new()
    {
        public Question_9(t aaa)
        {
            Console.WriteLine("aaa");
        }
    }
}
