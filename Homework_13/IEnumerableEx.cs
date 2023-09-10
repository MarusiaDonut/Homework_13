using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework_13
{
    public static class IEnumerableEx
    {
        public static IEnumerable<int> Top<T>(this IEnumerable<T> list, double p)
        {
            var text = list.ToList().All(x => Convert.ToInt32(x) < 100 && Convert.ToInt32(x) > 0);
            if (list.Count() < 100 && list.Count() > 1 && text == true)
            {
                var elementCount = Math.Ceiling(list.Count() * p / 100);

                return (IEnumerable<int>)list.OrderByDescending(x => x).Take(Convert.ToInt32(elementCount));
            }
            else
            {
                throw new ArgumentException("Значение должно быть больше 0 и меньше 100!");
            }

        }
    }
}
