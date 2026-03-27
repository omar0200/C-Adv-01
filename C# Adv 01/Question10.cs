using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class Question10<T> : IRepository<T> where T : interface
    {
        public void Update(T e)
        {
            throw new NotImplementedException();
        }
    
}
}
