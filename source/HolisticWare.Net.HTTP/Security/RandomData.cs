using System;

namespace HolisticWare.Security
{
    /// <summary>
    /// Random Data utility clas for OAuth
    /// </summary>
    /// <see cref="http://packagesearch.azurewebsites.net/?q=RandomNumberGenerator"/>
    public partial class RandomData
    {
        public RandomData()
        {
        }

        static int seed;
        #if NETSTANDARD1_3
        // from System.Security.Cryptography 
        // designed to be used with cryptographic algorithms
        static System.Security.Cryptography.RandomNumberGenerator rand = null;
        #else
        static System.Random rand = null;
        #endif

        static RandomData()
        {
            seed = Convert.ToInt32(DateTime.Now.Subtract(DateTime.Today).TotalSeconds);

            // changing the seed to get more randomized
            #if NETSTANDARD1_3
            rand = System.Security.Cryptography.RandomNumberGenerator.Create();
            #else
            rand = new System.Random(seed);
            #endif

            return;
        }

        public string RandomString(ulong number_of_characters = 16)
        {
            //
            // Generate a unique state string to check for forgeries
            //

            char[] chars = new char[number_of_characters];

            for (var i = 0; i < chars.Length; i++)
            {
                #if NETSTANDARD1_3
                #else
                chars[i] = (char)rand.Next((int)'a', (int)'z' + 1);
                #endif
            }

            #if NETSTANDARD1_3
            byte[] bytes_random = new byte[number_of_characters];
            rand.GetBytes(bytes_random);
            chars = System.Text.Encoding.ASCII.GetString(bytes_random).ToCharArray(); 
            #else
            #endif

            string state_string = new string(chars);

            return state_string;
        }


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

        public string RandomDataBase64Url(uint length)
        {
            byte[] bytes = new byte[length];

            // original code
            //RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            #if NETSTANDARD1_3
            // from System.Security.Cryptography 
            // designed to be used with cryptographic algorithms
            System.Security.Cryptography.RandomNumberGenerator rng = null;
            rng = System.Security.Cryptography.RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            #else
            //  insecure (albeit faster) Random class
            System.Random rng = new System.Random();
            rng.NextBytes(bytes);
            #endif

            return Base64UrlEncodeNoPadding(bytes);
        }

        /// <summary>
        /// Returns the SHA256 hash of the input string.
        /// </summary>
        /// <param name="input_string"></param>
        /// <returns></returns>
        public byte[] ComputeSHA256Hash(string input_string)
        {
            #if NETSTANDARD1_3
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(input_string);
            #else
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input_string);
            #endif

            // original code
            //SHA256Managed sha256 = new SHA256Managed();
            byte[] hash = null;

            #if NETSTANDARD1_3
            using (System.Security.Cryptography.SHA256 algorithm = System.Security.Cryptography.SHA256.Create())
            {
                hash = algorithm.ComputeHash(bytes);
            }
            #else
            #endif

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
        public string Base64UrlEncodeNoPadding(byte[] buffer)
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
