using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Net;

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// HTTP Client interface
    ///     Fluent interface
    ///     mimic CURL
    /// </summary>
    public partial interface IClient
    {
        //---------------------------------------------------------------------------
        // GET
        // curl https://curl.haxx.se
        // curl https://curl.haxx.se http://xamarin.com
        Task<Client> RequestGetAsync
                            (
                            );

        //Task<string> RequestStringAsync
                                    //(
                                    //   string url
                                    //);

        // POST
        // curl \
        //      --data name=curl \
        //      --data date=2017-10-28 \
        //      http://url.example.com
        // curl --data name=curl http://url1.example.com http://url2.example.com

        Task<Client> RequestPostAsync
                            (
                                string data
                            );

        //Task<Client> RequestPostAsync
                            //(
                            //    string[] data
                            //);

        Task<Client> RequestPostAsync
                            (
                                IDictionary<string, string> data
                            );

        //Task<string> RequestStringAsync
                                    //(
                                    //   string url,
                                    //   string data
                                    //);
        //---------------------------------------------------------------------------

        //---------------------------------------------------------------------------
        // GET
        //Task<string> RequestGetStringAsync
        //                            (
        //                               string url,
        //                               string data = null
        //                            );

        //Task<string> RequestGetStringAsync
        //                            (
        //                               Uri url,
        //                               string data = null
        //                            );

        //Task<string> RequestGetStringAsync
        //                            (
        //                               Uri url,
        //                               IDictionary<string, string> data = null
        //                            );

        //Task<string> RequestGetStringAsync
                                   //(
                                   //    string url,
                                   //    IDictionary<string, string> data = null
                                   //);


    }
}
