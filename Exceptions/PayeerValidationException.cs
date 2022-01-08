using System;

namespace Payeer.Api.Exceptions
{
    public sealed class PayeerValidationException : Exception
    {
        internal PayeerValidationException(string message)
            : base(message)
        {
        }
    }
}
