using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public static class Filters
    {

        //public delegate bool Criteria(int item);


        public static List<int> Filter(List<int> values, Func<int, bool> criteria)
        {
            List<int> filtered = new List<int>();
            foreach (var item in values)
            {
                if (criteria(item))
                {
                    filtered.Add(item);
                }
            }

            return filtered;
        }

    }
}
