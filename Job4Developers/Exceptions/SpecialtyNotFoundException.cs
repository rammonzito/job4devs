using System;
using System.Runtime.Serialization;

namespace Job4Developers.Exceptions
{
    public class SpecialtyNotFoundException : Exception
    {
        public SpecialtyNotFoundException()
        {
        }

        public SpecialtyNotFoundException(string message) : base(message)
        {
        }

        public SpecialtyNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SpecialtyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
