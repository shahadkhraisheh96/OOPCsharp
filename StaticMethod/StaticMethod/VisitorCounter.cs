using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class VisitorCounter
    {
        public static int counter = 0;

        public VisitorCounter()
        {
            counter++;
        }

        public int display()
        {
            return counter;
        }
    }
}
