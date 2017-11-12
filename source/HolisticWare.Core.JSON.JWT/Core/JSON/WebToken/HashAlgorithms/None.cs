using System;

namespace Core.JSON.WebToken.Algorithms
{
    /// <summary>
    /// None - Hash algorithm for JWT (unsecured JWT)
    /// </summary>
    public partial class None : IHashAlgorithm
    {
        public None()
        {
        }

        public string Name
        {
            get
            {
                return "none";
            }
        }

        public byte[] GenerateSignature(byte[] data, byte[] key)
        {
            byte[] data_hash = null;

            return data_hash;
        }

    }
}
