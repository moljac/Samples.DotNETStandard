using System;

namespace Core.Text.Encodings
{
    /// <summary>
    /// Base64 encoding class
    /// </summary>
    /// 
    public class Base64Encoding
    {
        public Base64Encoding()
        {
            return;
        }


        /// <summary>
        /// Base64url Encode the specified input buffer
        /// </summary>
        /// <returns>Base64Url encoded string</returns>
        /// <param name="buffer">byte[] input buffer</param>
        public virtual string Encode(byte[] buffer)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException(nameof(buffer));
            }

            if (buffer.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(buffer));
            }

            string base64 = Convert.ToBase64String(buffer);

            return base64;
        }

        public virtual string Encode(string buffer_textual)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(buffer_textual);

            return this.Encode(buffer);
        }


        /// <summary>
        /// Base64Url 
        /// </summary>
        /// <returns>The decode.</returns>
        /// <param name="base64">Base64.</param>
        public virtual byte[] Decode(string base64)
        {
            if (String.IsNullOrWhiteSpace(base64))
            {
                throw new ArgumentException(nameof(base64));
            }

            byte[] buffer = Convert.FromBase64String(base64); // Standard base64 decoder

            return buffer;
        }

        public virtual string DecodeAsString(string base64)
        {
            byte[] buffer = this.Decode(base64);

            string buffer_textual = System.Text.Encoding.UTF8.GetString(buffer,0, buffer.Length);

            return buffer_textual;
        }

    }
}
