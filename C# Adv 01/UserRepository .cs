using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_01
{
    internal class UserRepository<T> : IRepository<T> where T : class
    {

        public void Update(T e)
        {
            Console.WriteLine("Updated");
        }
    }
}
