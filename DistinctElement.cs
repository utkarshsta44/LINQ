using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class DistinctElement
    {
        public static void Method()
        {

            List<int> list1 = new List<int>() { 1, 2, 3, 3, 3, 4 };
            List<string> strList = new List<string>() { "One", "Two", "One", "Two", "Three" };

            var distinctElement1 = strList.Distinct();
            var distinctElement2 = list1.Distinct();
            foreach (int item in distinctElement2)
            {
                Console.WriteLine(item);
            }
        }
    }
}