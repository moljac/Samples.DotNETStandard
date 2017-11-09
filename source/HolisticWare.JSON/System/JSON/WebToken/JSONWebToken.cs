using System;
using System.Collections.Generic;
using System.Text;

namespace Core.JSON.WebToken
{
    /// <summary>
    /// JSON Web Token.
    /// Lightweight JSON Web Token class
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.identitymodel.tokens.jwtheader(v=vs.114).aspx"/>
    public partial class JSONWebToken
    {
        public JSONWebToken()
        {
        }

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

        public string Signature
        {
            get;
        }

        public string Encode()
        {
            string encoded = null;

            switch(this.Header["alg"])
            {
                case "none":
                    break;
                case "HS256":
                    break;
            }
                   
            return encoded;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append();
            return 
        }

   }
}
