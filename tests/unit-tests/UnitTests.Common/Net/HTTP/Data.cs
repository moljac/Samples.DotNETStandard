using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Common.Net.HTTP
{
    public partial class Data
    {
        public static string UriAPIRequestBin
        {
            get
            {
                return url_api;
            }
            set
            {
                url_api = value;
            }
        }
        protected static string url_api = $"https://requestb.in/{id_requestbin}";

        public static string IdRequestBin
        {
            get
            {
                return id_requestbin;
            }
            set
            {
                id_requestbin = value;
            }
        }
        protected static string id_requestbin = "yxhhewyx";

    }
}
