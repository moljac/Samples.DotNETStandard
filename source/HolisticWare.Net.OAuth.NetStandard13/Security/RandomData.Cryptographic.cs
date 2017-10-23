using System;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace HolisticWare.Security
{
    /// <summary>
    /// Random Data utility clas for OAuth
    /// </summary>
    /// <see cref="http://packagesearch.azurewebsites.net/?q=RandomNumberGenerator"/>
    /*
        2017-10-21

        in .NET Standard are no classes like:
        
        RNGCryptoServiceProvider
        http://packagesearch.azurewebsites.net/?q=RNGCryptoServiceProvider

        SHA256Managed
        http://packagesearch.azurewebsites.net/?q=SHA256Managed

        https://github.com/googlesamples/oauth-apps-for-windows
        https://github.com/googlesamples/oauth-apps-for-windows/blob/master/OAuthConsoleApp/OAuthConsoleApp/Program.cs
    */
    public partial class RandomData
    {
        public string RandomDataBase64Url(uint length)
        {
            //RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            RandomNumberGenerator rng = RandomNumberGenerator.Create();

            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);

            return Base64urlencodeNoPadding(bytes);
        }

        /// <summary>
        /// Returns the SHA256 hash of the input string.
        /// </summary>
        /// <param name="input_string"></param>
        /// <returns></returns>
        public byte[] ComputeSHA256Hash(string input_string)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(input_string);
            //SHA256Managed sha256 = new SHA256Managed();
            byte[] hash = null;

            using (SHA256 algorithm = SHA256.Create())
            {
                hash = algorithm.ComputeHash(bytes);
            }

            return hash;
        }

        // Note: only the left-most half of the hash of the octets is used.
        // See http://openid.net/specs/openid-connect-core-1_0.html#CodeIDToken
        //identity.AddClaim(JwtRegisteredClaimNames.AtHash, Base64UrlEncoder.Encode(hash, 0, hash.Length / 2));


        /// <summary>
        /// Base64url no-padding encodes the given input buffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public string Base64urlencodeNoPadding(byte[] buffer)
        {
            string base64 = Convert.ToBase64String(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-");
            base64 = base64.Replace("/", "_");
            // Strips padding.
            base64 = base64.Replace("=", "");

            return base64;
        }

    }
}
