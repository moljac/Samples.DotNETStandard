using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

using HolisticWare.Net;

namespace HolisticWare.Net.HTTP
{
    public partial class Client : IClient
    {
        //System.Net.HttpWebRequest http_web_request = null;
        //System.Net.HttpWebResponse http_web_response = null;
        //System.Net.WebRequest web_request = null;
        //System.Net.HttpRequestHeader http_request_header;


        // GET
        public Client RequestGetAsync()
        {
            this
                .Method("GET")
                //.Headers()            // default headers
                //.Parameters()         // Data/Parameters
                ;

            foreach(Uri uri in this.EndPoints)
            {
                StringBuilder sb_uri = new StringBuilder();
                sb_uri.Append(uri.OriginalString).Append('?').Append(this.DataAsString);
                //http_web_request = (HttpWebRequest) WebRequest.Create(sb_uri.ToString());
                //http_web_request.Method = this.RequestMethodVerb;

                foreach(KeyValuePair<string, string> kvp in this.RequestHeaders)
                {
                    //http_web_request.Headers[kvp.Key] = kvp.Value;
                }


            }

            return this; 
        }

        // POST
        public async Task<Client> RequestPostAsync(IDictionary<string, string> data)
        {
            return this;
        }

        public async Task<Client> RequestPostAsync(string data)
        {
            this
                .Method("POST")
                //.Headers()            // default headers
                //.Parameters()         // Data/Parameters
                ;
            
            //StringBuilder url_sb = new StringBuilder(url).Append("?").Append(query);

            //this
                //.UrlEndpoint(urls)
                //.Parameters(query_map)
                //.Data(query_map)
                //;


            // web_request = new System.Net.WebRequest(); // cannot create instance
            //http_web_request =
            //    // new System.Net.HttpWebRequest()
            //    System.Net.WebRequest.CreateHttp("".ToString())
            //    ;

            //this.HttpRequestSetup(http_web_request);
            //http_web_response = (HttpWebResponse)await http_web_request.GetResponseAsync();

            return this;
        }

    }
} 
