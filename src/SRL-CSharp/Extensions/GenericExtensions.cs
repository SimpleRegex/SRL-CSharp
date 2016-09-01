using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Extensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Determines whether this instance is list.
        /// </summary>
        /// <param name="o">The o object</param>
        /// <returns>
        ///   <c>true</c> if the specified o is list; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsList(this object o)
        {
            if (o == null)
            {
                return false;
            }

            return o is IList && o.GetType().IsGenericType && o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
        }

        /// <summary>
        /// Determines whether this instance is dictionary.
        /// </summary>
        /// <param name="o">The o object</param>
        /// <returns>
        ///   <c>true</c> if the specified o is dictionary; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDictionary(this object o)
        {
            if (o == null)
            {
                return false;
            }

            return o is IDictionary && o.GetType().IsGenericType && o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(Dictionary<,>));
        }
    }
}
