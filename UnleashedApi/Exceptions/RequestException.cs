﻿using System;
using System.Runtime.Serialization;

namespace UnleashedApi.Exceptions
{
    public class RequestException : Exception
    {
        public RequestException()
        {
        }

        public RequestException(string message) : base(message)
        {
        }

        public RequestException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
