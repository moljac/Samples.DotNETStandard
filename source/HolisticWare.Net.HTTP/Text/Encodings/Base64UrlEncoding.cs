using System;

namespace Core.Text.Encodings
{
    /// <summary>
    /// Base64 URL encoding.
    /// </summary>
    /// 
    public class Base64UrlEncoding : Base64Encoding
    {
        public Base64UrlEncoding()
        {
        }


        /// <summary>
        /// Base64url encodes the given input buffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns>string</returns>


        /// <summary>
        /// Base64url Encode the specified buffer and remove padding if neccessary.
        /// </summary>
        /// <returns>Base64Url encoded string</returns>
        /// <param name="buffer">Buffer.</param>
        /// <param name="IsPadded">If set to <c>true</c> is padded.</param>
        public string Encode(byte[] buffer, bool is_padded = true, bool is_padded_optimized = false)
        {
            this.IsPadded = is_padded;
            this.IsPaddedOptimized = is_padded_optimized;

            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            if (buffer.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(buffer));
            }

            string base64 = base.Encode(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-"); // 62nd char of encoding
            base64 = base64.Replace("/", "_"); // 63rd char of encoding

            if (is_padded == false)
            {
                // Strip padding

                // https://github.com/googlesamples/oauth-apps-for-windows/blob/master/OAuthConsoleApp/OAuthConsoleApp/Program.cs#L64-L68
                base64 = base64.Replace("=", "");
                // https://github.com/jwt-dotnet/jwt/blob/master/src/JWT/JwtBase64UrlEncoder.cs#L21
                // base64.Split('=')[0]; // Remove any trailing '='s
            }
            else
            {
                if (is_padded_optimized == true)
                {
                    base64 = base64.Replace("=", "");

                    switch (base64.Length % 4) // Pad with trailing '='s
                    {
                        case 0:
                            if (this.IsPaddedOptimized)
                            {
                                base64 += "0";
                            }
                            break; // No pad chars in this case
                        case 2:
                            if (this.IsPaddedOptimized)
                            {
                                base64 += "2";
                            }
                            else
                            {
                                base64 += "==";
                            }
                            break; // Two pad chars
                        case 3:
                            if (this.IsPaddedOptimized)
                            {
                                base64 += "1";
                            }
                            else
                            {
                                base64 += "=";
                            }
                            break; // One pad char
                        default:
                            throw new FormatException("Illegal base64url string!");
                    }
                }
            }

            return base64;
        }

        public bool IsPadded
        {
            get;
            set;
        }

        public bool IsPaddedOptimized
        {
            get;
            set;
        }

        /// <summary>
        /// Base64Url 
        /// </summary>
        /// <returns>The decode.</returns>
        /// <param name="base64">Base64.</param>
        public byte[] Decode(string base64, bool is_padded = false, bool is_padded_optimized = false)
        {
            this.IsPadded = is_padded;
            this.IsPaddedOptimized = is_padded_optimized;

            if (String.IsNullOrWhiteSpace(base64))
            {
                throw new ArgumentException(nameof(base64));
            }

            string base64_padded = base64;
            base64_padded = base64_padded.Replace('-', '+'); // 62nd char of encoding
            base64_padded = base64_padded.Replace('_', '/'); // 63rd char of encoding

            if (is_padded_optimized == true)
            {
                switch (base64_padded.Length % 4) // Pad with trailing '='s
                {
                    case 0:
                        if (this.IsPaddedOptimized)
                        {
                            base64_padded += "0";
                        }
                        break; // No pad chars in this case
                    case 2:
                        if (this.IsPaddedOptimized)
                        {
                            base64_padded += "2";
                        }
                        else
                        {
                            base64_padded += "==";
                        }
                        break; // Two pad chars
                    case 3:
                        if (this.IsPaddedOptimized)
                        {
                            base64_padded += "1";
                        }
                        else
                        {
                            base64_padded += "=";
                        }
                        break; // One pad char
                    default:
                        throw new FormatException("Illegal base64url string!");
                }
            }

            byte[] buffer = Convert.FromBase64String(base64_padded); // Standard base64 decoder

            return buffer;
        }
    }
}
