using System;
using System.Runtime.Serialization;

namespace Scm.Common.Domain.Shared.Exceptions
{
    [Serializable]
    public class ConverterException : Exception
    {
        public ConverterException()
        {
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref = "ConverterException" /> class.
        /// </summary>
        /// <param name = "message">The message.</param>
        public ConverterException(string message)
            : base(message)
        {
            HelpLink = "https://scssolutions.io/";
        }

        public ConverterException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected ConverterException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}