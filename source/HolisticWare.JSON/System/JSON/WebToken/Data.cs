using System;
using System.Collections.Generic;

namespace Core.JSON.WebToken
{
    /// <summary>
    /// JSON Web Token.
    /// Lightweight JSON Web Token class
    /// </summary>
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
