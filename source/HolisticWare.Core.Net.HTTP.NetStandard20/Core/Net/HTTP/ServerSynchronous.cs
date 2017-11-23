using System;

namespace Core.Net.HTTP
{
    public class ServerSynchronous
    {
        public ServerSynchronous(string[] prefixes)
        {
            System.Net.HttpListener listener = new System.Net.HttpListener();

            foreach (string prefix in prefixes)
            {
                listener.Prefixes.Add(prefix);
            }

            listener.Start();

            while (true)
            {
                try
                {
                    var context = listener.GetContext(); //Block until a connection comes in
                    context.Response.StatusCode = 200;
                    context.Response.SendChunked = true;

                    int totalTime = 0;

                    while (true)
                    {
                        if (totalTime % 3000 == 0)
                        {
                            var bytes = System.Text.Encoding.UTF8.GetBytes(new string('3', 1000) + "\n");
                            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                        }

                        if (totalTime % 5000 == 0)
                        {
                            var bytes = System.Text.Encoding.UTF8.GetBytes(new string('5', 1000) + "\n");
                            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
                        }

                        System.Threading.Thread.Sleep(1000);
                        totalTime += 1000;
                    }

                }
                catch (Exception)
                {
                    // Client disconnected or some other error - ignored for this example
                }
            }

            return;
        }

    }
}
