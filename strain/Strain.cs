using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> selector)
    {
        foreach (var element in collection)
            if (selector(element))
                yield return element;
    }
    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> selector)
    {
        return collection.Keep(element => !selector(element));
    }
}