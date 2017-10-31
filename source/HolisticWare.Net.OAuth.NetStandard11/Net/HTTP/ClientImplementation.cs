using System;
namespace HolisticWare.Net.HTTP
{
    public partial class ClientImplementation<T>
        // where T : System.Net.Http.HttpClient
    {
        public ClientImplementation()
        {
            if 
                (
                    typeof(T) == typeof(System.Net.Http.HttpRequestMessage)
                    ||
                    typeof(T) == typeof(System.Net.Http.HttpResponseMessage)
                )
            {                
            }
            else
            {
                throw new ArgumentException("Client implementation can use only HttpRequestMessage and HttpResponseMessage");
            }

            return;
        }

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

        public static implicit operator T(ClientImplementation<T> ci)
        {
            return ci.ImplementationObject;
        }

        public static implicit operator ClientImplementation<T>(T io)
        {
            ClientImplementation<T> ci = new ClientImplementation<T>();
            ci.ImplementationObject = io;

            return ci;
        }        
    }
}
