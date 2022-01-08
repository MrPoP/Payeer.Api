using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payeer.Api
{
    public sealed class PayeerClient : IPayeerClient
    {
        private const string ArgumentMustNotBeNullOrEmpty = "Argument must not be null or empty";
        public const string HttpClientName = "URI";

    }
}
