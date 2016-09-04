using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;

namespace SRL.Extensions
{
    [DebuggerStepThrough]
    public static class GenericTypeExtensions
    {
        /// <summary>
        /// Determines whether this instance is list.
        /// </summary>
        /// <param name="obj">The o object</param>
        /// <returns>
        ///   <c>true</c> if the specified o is list; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsList(this object obj)
        {
            if (obj.IsNull())
            {
                return false;
            }

            return (obj is IList) && 
                (obj.GetType().IsGenericType) && 
                (obj.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)));
        }

        /// <summary>
        /// Determines whether the object is not null
        /// </summary>
        /// <typeparam name="TObject">The object type.</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>true if the object is not null; otherwise, false.</returns>
        public static bool IsNotNull<TObject>(this TObject obj)
            where TObject : class
        {
            return !IsNull(obj);
        }

        /// <summary>
        /// Determines whether the object is null
        /// </summary>
        /// <typeparam name="TObject">The object type.</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>true if the object is null; otherwise, false.</returns>
        public static bool IsNull<TObject>(this TObject obj)
         where TObject : class
        {
            return Object.ReferenceEquals(obj, null);
        }

        /// <summary>
        /// Determines whether this instance is dictionary.
        /// </summary>
        /// <param name="obj">The o object</param>
        /// <returns>
        ///   <c>true</c> if the specified o is dictionary; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDictionary(this object obj)
        {
            if (obj.IsNull())
            {
                return false;
            }

            return (obj is IDictionary) && 
                (obj.GetType().IsGenericType) && 
                (obj.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(Dictionary<,>)));
        }

        /// <summary>
        /// Cast a instance to the specified instance.
        /// </summary>
        /// <typeparam name="TObject"></typeparam>
        /// <param name="obj">The instance.</param>
        /// <returns>The instance specified</returns>
        public static TObject As<TObject>(this object obj) 
            where TObject : class
        {
            if (obj.IsNull())
            {
                return default(TObject);
            }

            return obj as TObject;
        }
    }
}
