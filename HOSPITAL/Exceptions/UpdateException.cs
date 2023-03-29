using System.Runtime.Serialization;

namespace HOSPITAL.Exceptions
{
    [Serializable]
    internal class UpdateException : Exception
    {
        public UpdateException()
        {
        }

        public UpdateException(string? message) : base(message)
        {
        }

        public UpdateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UpdateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}