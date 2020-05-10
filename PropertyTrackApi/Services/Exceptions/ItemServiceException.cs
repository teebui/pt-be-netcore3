using System;
using System.Runtime.Serialization;

namespace PropertyTrackApi.Services.Exceptions
{
    [Serializable]
    internal class ItemServiceException : Exception
    {
        public ItemServiceException()
        {
        }

        public ItemServiceException(string message) : base(message)
        {
        }

        public ItemServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}