using System;

namespace Core.JSON.WebToken.Algorithms
{
    public partial class HMACSHA256 : IHashAlgorithm
    {
        public HMACSHA256()
        {
        }

        public string Name 
        { 
            get
            {
                return "HS256";
            }
        }

        public byte[] GenerateSignature(byte[] data, byte[] key)
        {
            byte[] data_hash = null;

            #if NETSTANDARD1_3
            using (System.Security.Cryptography.HMACSHA256 sha = new System.Security.Cryptography.HMACSHA256(key))
            {
                data_hash = sha.ComputeHash(data);
            }
            #endif

            return data_hash;
        }

    }
}
