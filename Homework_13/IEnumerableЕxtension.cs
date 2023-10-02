
namespace Homework_13
{
    public static class IEnumerableЕxtension
    {
        public static IEnumerable<int> Top<T>(this IEnumerable<T> list, int p)
        {
            bool isPercentage = p < 100 && p > 0;

            if (isPercentage)
            {
                var elementCount = Math.Ceiling(list.Count() * (double)p / 100);

                return (IEnumerable<int>)list.OrderByDescending(x => x).Take(Convert.ToInt32(elementCount));
            }
            else
            {
                throw new ArgumentException("Заданное количество процентов должно быть больше 0 и меньше 100!");
            }

        }
    }
}
