using System.Collections.Generic;
using System.Linq;

namespace ReadOnlyListAdvantage
{
    public static class ExtensionMethods
    {
        public static IReadOnlyCollection<T> AsReadOnlyList<T>(this IEnumerable<T> enumT) => (enumT as List<T> ?? enumT.ToList()).AsReadOnly();
        
    }
}