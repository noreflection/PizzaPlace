using System.Collections;

namespace PizzaStore.Shared
{
    // ReSharper disable once InconsistentNaming
    public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable) =>
            enumerable.GetEnumerator().MoveNext() == true;
    }
}
