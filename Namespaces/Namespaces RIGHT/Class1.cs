using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces_2
{
    internal class Class1
    {
        private int koek;

        public void Feed(int amount)
        {
            koek -= amount;
            Console.WriteLine(koek);
        }
    }


}
