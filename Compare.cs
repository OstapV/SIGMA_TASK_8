using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGMA_7_1
{
    class Compare
    {
        static public int ComparePrice(object x1, object x2)
        {
            Product obj1 = (Product)x1;
            Product obj2 = (Product)x2;

            return obj1.Price.CompareTo(obj2.Price);
        }

        static public int CompareName(object x1, object x2)
        {
            Product obj1 = (Product)x1;
            Product obj2 = (Product)x2;

            return obj1.Name[0].CompareTo(obj2.Name[0]);
        }

    }
}
