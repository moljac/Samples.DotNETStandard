using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Common.Net.HTTP
{
    /// <summary>
    /// Data.
    /// </summary>
    public partial class Data
    {
        
        public static Dictionary<string, string> UriAPIs
        {
            get
            {
                return url_apis;
            }
            set
            {
                url_apis = value;
            }
        }

        protected static Dictionary<string, string> url_apis = new Dictionary<string, string>()
        {
            {
                // https://requestb.in/
                // RequestBin gives you a URL that will collect requests made to it and let you 
                // inspect them in a human-friendly way. Use RequestBin to see what your HTTP client is 
                //sending or to inspect and debug webhook requests.

                // Limits
                // This bin will keep the last 20 requests made to it and remain available for 48 
                // hours after it was created. However, data might be cleared at any time, so treat 
                // bins as highly ephemeral.
                $"RequestBin",     
                $"https://requestb.in/resi9wre"
            },
            {
                // http://posttestserver.com/
                // server which receives any POST you wish to give it and stores the contents for you to 
                // review.
                // http://posttestserver.com/data/
                // http://posttestserver.com/data/2017/10/31/holisticware-xamarin-auth/
                $"POST server",    
                $"http://posttestserver.com/post.php?dir=holisticware-xamarin-auth"
            },
            {
                // PutsReq lets you record HTTP requests and fake responses
                $"PutsReq",        
                $"http://putsreq.com/YWlqs0G2IaOsyQbGNWtm"
            }
        };
    }
}
