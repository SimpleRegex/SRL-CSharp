using System.Collections.Generic;

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

        private static readonly Dictionary<PregExceptionEnum, string> messages = new Dictionary<PregExceptionEnum, string>
        {
            { PregExceptionEnum.InternalError, PREG_INTERNAL_ERROR },
            { PregExceptionEnum.BacktrackLimitError, PREG_BACKTRACK_LIMIT_ERROR },
            { PregExceptionEnum.RecursionLimitError, PREG_RECURSION_LIMIT_ERROR },
            { PregExceptionEnum.BadUtf8Error, PREG_BAD_UTF8_ERROR },
            { PregExceptionEnum.BadUtf8OffsetError, PREG_BAD_UTF8_OFFSET_ERROR },
            { PregExceptionEnum.JitStacklimitError, PREG_JIT_STACKLIMIT_ERROR }
        };

        public PregException(PregExceptionEnum type) : base(messages[type])
        {
        }
    }

    public enum PregExceptionEnum
    {
        InternalError,
        BacktrackLimitError,
        RecursionLimitError,
        BadUtf8Error,
        BadUtf8OffsetError,
        JitStacklimitError
    }
}
