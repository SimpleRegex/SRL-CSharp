using System;

namespace SRL.Exceptions
{
    public class SRLException : Exception
    {
        public SRLException() { }

        public SRLException(string message) : base(message) { }

        public SRLException(string message, Exception previous) : base(message, previous) { }
    }
}
