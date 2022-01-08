using System;
using System.Net;
using System.Net.Http;

namespace Payeer.Api.Exceptions
{
    public class PayeerApiException : Exception
    {
        internal PayeerApiException(HttpStatusCode httpStatusCode, HttpContent httpContent)
        {
            HttpStatusCode = httpStatusCode;
            HttpContent = httpContent;
        }
        public HttpStatusCode HttpStatusCode { get; }

        public HttpContent HttpContent { get; }
    }
}
