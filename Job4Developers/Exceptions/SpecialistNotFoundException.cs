using System;
using System.Runtime.Serialization;

namespace Job4Developers.Exceptions
{
    public class SpecialistNotFoundException : Exception
    {
        public SpecialistNotFoundException()
        {
        }

        public SpecialistNotFoundException(string message) : base(message)
        {
        }

        public SpecialistNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SpecialistNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
