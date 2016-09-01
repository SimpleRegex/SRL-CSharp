using System;

namespace SRL.Exceptions
{
    public abstract class SRLException : Exception
    {
        protected SRLException() { }

        protected SRLException(string message) : base(message) { }

        protected SRLException(string message, Exception previous) : base(message, previous) { }
    }
}
