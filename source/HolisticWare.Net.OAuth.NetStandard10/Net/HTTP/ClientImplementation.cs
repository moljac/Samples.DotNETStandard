using System;
namespace HolisticWare.Net.HTTP
{
    public partial class ClientImplementation<T>
        // where T : System.Net.HttpWebRequest
    {
        public ClientImplementation()
        {
            // WebRequest and WebResponse (HttpWebRequest and HttpWebResponse) 
            // do not have common base class, so constraints for generics cannot be applied            
            if 
            (
                typeof(T) == typeof(System.Net.HttpWebRequest) 
                || 
                typeof(T) == typeof(System.Net.HttpWebResponse)
            )
            {                
            }
            else
            {
                throw new ArgumentException("Client implementation can use only HttpWebRequest and HttpWebResponse");
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
