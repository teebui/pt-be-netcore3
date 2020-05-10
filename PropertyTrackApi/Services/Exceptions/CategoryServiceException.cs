using System;
using System.Runtime.Serialization;

namespace PropertyTrackApi.Services.Exceptions
{
    [Serializable]
    internal class CategoryServiceException : Exception
    {
        public CategoryServiceException()
        {
        }

        public CategoryServiceException(string message) : base(message)
        {
        }

        public CategoryServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CategoryServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}