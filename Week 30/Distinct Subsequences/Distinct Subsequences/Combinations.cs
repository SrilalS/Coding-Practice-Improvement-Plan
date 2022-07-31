using System.Collections.Generic;
using System.Linq;

namespace Distinct_Subsequences
{
    static class Combinations
    {
        public static IEnumerable<IEnumerable<T>> GetCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
              elements.SelectMany((e, i) =>
                elements.Skip(i + 1).GetCombinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}
