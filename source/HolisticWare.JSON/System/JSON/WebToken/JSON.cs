using System;
using System.Collections.Generic;

namespace Core.JSON.WebToken
{
    /// <summary>
    /// JSON Web Token.
    /// Lightweight JSON Web Token class
    /// </summary>
    public partial class JSON
    {
        public System.Json.JsonValue Header
        {
            get;
            set;
        }

        public System.Json.JsonValue Payload
        {
            get;
            set;
        }
   }
}
