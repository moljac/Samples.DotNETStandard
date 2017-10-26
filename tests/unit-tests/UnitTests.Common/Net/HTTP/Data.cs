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
            {$"RequestBin",     $"https://requestb.in/108voy71"},
            {$"POST server",    $"http://posttestserver.com/post.php?dir=holisticware-xamarin-auth"},
            {$"PutsReq",        $"http://putsreq.com/WkUY3qJajJXXYtClyGeW"}
        };
    }
}
