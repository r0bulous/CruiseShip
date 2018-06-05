using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACruise
{
    class Travel
    {
        public int Age { get; set; }
        public int Value { get; set; }
        public string ReturnValue { get; set; }

        public Travel()
        {
            //Default constructor
        }
        public int CustAge()
        {
            if (Age == 35)
            {
                return 1;
            }
            else if (Age == 36)
            {
                return 2;
            }
            else if (Age == 37)
            {
                return 3;
            }
            else if (Age == 38)
            {
                return 4;
            }
            else if (Age == 39)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

    }
}

