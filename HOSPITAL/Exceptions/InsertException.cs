using System.Runtime.Serialization;

namespace HOSPITAL.Exceptions
{
    [Serializable]
    internal class InsertException : Exception
    {
        public InsertException()
        {
        }

        public InsertException(string? message) : base(message)
        {
        }

        public InsertException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InsertException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}