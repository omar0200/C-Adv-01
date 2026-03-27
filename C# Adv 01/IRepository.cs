using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal interface IRepository<T> where T : class
    {
        void Update(T e);
    }
}
