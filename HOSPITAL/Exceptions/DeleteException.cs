﻿using System.Runtime.Serialization;

namespace HOSPITAL.Exceptions
{
    [Serializable]
    internal class DeleteException : Exception
    {
        public DeleteException()
        {
        }

        public DeleteException(string? message) : base(message)
        {
        }

        public DeleteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeleteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}