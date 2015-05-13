using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETUtils.Extensions
{
    public static class ObjectExtensions
    {
        public static bool In<T>(this T tObject, params T[] atObjects)
        {
            return atObjects.Contains(tObject);
        }
    }
}
