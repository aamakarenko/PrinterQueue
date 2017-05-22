using System;
using System.Collections.Generic;
using System.Linq;

namespace PrinterQueue.Generator
{
    public static class Utils
    {
        static Random rnd = new Random();

        public static object GetRandomObject<T>(this List<T> list)
        {
            int i = rnd.Next(list.Count);

            return list.ElementAt(i);
        }
    }
}
