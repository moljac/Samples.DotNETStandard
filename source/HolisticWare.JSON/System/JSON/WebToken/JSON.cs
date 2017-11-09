using System;
using System.Collections.Generic;

namespace Core.JSON.WebToken
{
    /// <summary>
    /// JSON Web Token.
    /// Lightweight JSON Web Token class
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.identitymodel.tokens.jwtheader(v=vs.114).aspx"/>
    public partial class Data
    {
        public Dictionary<string, string> Header
        {
            get;
            set;
        }

        public Dictionary<string, object> Payload
        {
            get;
            set;
        }

        public string Secret
        {
            get;
            set;
        }

   }
}
