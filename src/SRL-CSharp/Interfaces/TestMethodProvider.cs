using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRL.Extensions;
using System.Text.RegularExpressions;
using SRL.Exceptions;

namespace SRL.Interfaces
{
    public abstract class TestMethodProvider
    {
        /// <summary>
        /// Build and return the resulting regular expression. This will apply the given delimiter and all modifiers.
        /// </summary>
        /// <param name="delimiter">The delimiter to use. Defaults to '/'. If left empty, avoid using modifiers, since they then will be ignored.</param>
        /// <param name="ignoreInvalid">Ignore invalid regular expressions</param>
        /// <returns>The resulting regular expression</returns>
        public abstract string get(string delimiter = "/", bool ignoreInvalid = false);
        
        /// <summary>
        /// Test if regular expression matches given string
        /// </summary>
        /// <param name="string">The string to validate</param>
        /// <returns>true if the string is matched; otherwise, false</returns>
        public bool isMatching(string @string)
        {
            bool result = @string.PregMatch();
            if (!result)
            {
                throw new PregException(PregExceptionEnum.InternalError);
            }

            return result;
        }
    }
}
