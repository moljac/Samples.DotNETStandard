using System;

//-------------------------------------------------------------------------------------------------
// Aliases for readibility
#if NETSTANDARD1_0
// all platforms, non optimized
using ImplementationRequest = System.Net.HttpWebRequest;
using ImplementationResponse = System.Net.HttpWebResponse;
#else
// ! all platforms (missing Windows Phone 8 Silverlight), optimized for some Xamarin platforms:
//  
using ImplementationRequest = System.Net.Http.HttpRequestMessage;
using ImplementationResponse = System.Net.Http.HttpResponseMessage;
#endif
//-------------------------------------------------------------------------------------------------

namespace HolisticWare.Net.HTTP
{
    /// <summary>
    /// Client HTTP Request implementation - platform specific
    /// 
    /// This is helper class that enables generic property 
    /// 
    ///     // .NET Standard 1.0
    ///     ClientRequestImplementation<HttpWebResponse> Request
    ///     {
    ///     }
    /// 
    /// or
    /// 
    ///     // .NET Standard 1.1
    ///     ClientRequestImplementation<HttpResponseMessage> Request
    ///     {
    ///     }
    /// 
    /// Some ideas from:
    /// https://stackoverflow.com/questions/2587236/generic-property-in-c-sharp
    /// </summary>
    /// <see cref="https://stackoverflow.com/questions/2587236/generic-property-in-c-sharp"/>
    public partial class ClientResponseImplementation<T>
        where T
        :
        #if NETSTANDARD1_0
        System.Net.HttpWebResponse
        #else
        System.Net.Http.HttpResponseMessage
        #endif
    {
        protected T implementation_object;

        public T ImplementationObject
        {
            get
            {
                return implementation_object;
            }
            set
            {
                implementation_object = value;
            }
        }

        public static implicit operator T(ClientResponseImplementation<T> ci)
        {
            return ci.ImplementationObject;
        }

        public static implicit operator ClientResponseImplementation<T>(T io)
        {
            ClientResponseImplementation<T> ci = new ClientResponseImplementation<T>();
            ci.ImplementationObject = io;

            return ci;
        }        
    }
}
