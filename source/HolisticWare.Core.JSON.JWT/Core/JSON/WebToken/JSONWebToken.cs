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

        public Data TokenData
        {
            get;
            set;
        }

        public JSON TokenDataAsJSON
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

        public string Encode(string secret_key = null, IDictionary<string, object> payload = null)
        {
            string encoded = null;

            string alg = this.TokenData.Header["alg"];

            switch(this.TokenData.Header["alg"])
            {
                case "none":
                    break;
                case "HS256":
                    break;
                case "RS256":
                    break;
                default:
                    throw new ArgumentException($"Unknown JWT Header algorithm {alg}");
            }
                   
            return encoded;
        }

        public string Decode(string token = null, string secret_key = null)
        {
            string encoded = null;

            string alg = this.TokenData.Header["alg"];

            switch (this.TokenData.Header["alg"])
            {
                case "none":
                    break;
                case "HS256":
                    break;
                case "RS256":
                    break;
                default:
                    throw new ArgumentException($"Unknown JWT Header algorithm {alg}");
            }

            return encoded;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.TokenDataAsJSON.Header.ToString());
            sb.Append(".");
            sb.Append(this.TokenDataAsJSON.Header.ToString());
            sb.Append(".");
            if (this.TokenData.Algorithm != "none")
            {                
            }
            else
            {
                this.GenerateSignature(null);   
            }

            return sb.ToString();
        }

        private byte[] GenerateSignature(byte[] key)
        {
            Algorithms.IHashAlgorithm alg = new Algorithms.HMACSHA256();


            byte[] data = null;

            return alg.GenerateSignature(data, key);
        }
    }
}
