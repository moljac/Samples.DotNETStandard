using System;

namespace HolisticWare.Net.HTTP.OAuth.OAuth2
//namespace Xamarin.Auth.OAuth.OAuth2
{
    /// <summary>
    /// OAuth2 Parameter - State.
    /// RECOMMENDED.  An opaque value used by the client to maintain state between the 
    /// request and callback.The authorization server includes this value when redirecting 
    /// the user-agent back to the client.The parameter SHOULD be used for preventing cross-site 
    /// request forgery as described in Section 10.12.
    /// </summary>
    /// <see cref="https://tools.ietf.org/html/rfc6749#section-4.1.1"/>
    /// <see cref="https://tools.ietf.org/html/draft-bradley-oauth-jwt-encoded-state-00"/>
    /*
        more info:
        http://www.thread-safe.com/2014/05/the-correct-use-of-state-parameter-in.html
        https://security.stackexchange.com/questions/104167/what-to-use-as-state-in-oauth2-authorization-code-grant-workflow
    */
    public partial class State
    {
        public State()
        {
            RandomStateGeneratorFunc = GenerateOAuth2StateRandom;
            this.random_string = RandomStateGeneratorFunc(StateStringLength);

            return;
        }

        public ulong StateStringLength
        {
            get;
            set;
        } = 16;

        private string random_string;

        public string RandomString
        {
            get
            {
                return random_string;
            }
            set
            {
                random_string = value;

                return;
            }
        }

        /// <summary>
        /// Gets the random string URI escaped (URL encoded).
        /// </summary>
        /// <value>The random string URI escaped.</value>
        public string RandomStringUriEscaped
        {
            get
            {
                return Uri.EscapeUriString(random_string);
            }
        }

        /// <summary>
        /// Gets or sets the OAuth2 random state generator func.
        /// </summary>
        /// <value>
        /// The OA uth2 random state generator func.
        /// </value>
        public Func<ulong, string> RandomStateGeneratorFunc
        {
            get;
            set;
        }

        public string GenerateOAuth2StateRandom(ulong number_of_characters = 16)
        {
            return new Security.RandomData().RandomString(number_of_characters);
        }

    }
}
