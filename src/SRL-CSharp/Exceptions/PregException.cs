using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Exceptions
{
    public class PregException : SRLException
    {
        private const string PREG_INTERNAL_ERROR = "Internal PCRE error.";
        private const string PREG_BACKTRACK_LIMIT_ERROR = "Backtrack limit exhausted.";
        private const string PREG_RECURSION_LIMIT_ERROR = "Recursion limit exhausted.";
        private const string PREG_BAD_UTF8_ERROR = "Malformed UTF-8 data.";
        private const string PREG_BAD_UTF8_OFFSET_ERROR = "Offset did not correspond to the begin of a valid UTF-8 code point.";
        private const string PREG_JIT_STACKLIMIT_ERROR = "PCRE function failed due to limited JIT stack space.";
        
        //this is missing the Exception creation... looking for a better exception handling
    }
}
