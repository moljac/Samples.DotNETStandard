using System;

namespace Core.Net.HTTP
{
    /// <summary>
    /// Server.
    /// </summary>
    /// <see cref="https://gist.github.com/aksakalli/9191056"/>
    /// <see cref="https://gist.github.com/caioproiete/0a22dd020045a0fee239"/>
    /// <see cref="https://gist.github.com/joeandaverde/3994603"/>
    /// <see cref="https://codehosting.net/blog/BlogEngine/post/Simple-C-Web-Server"/>
    /// <see cref="https://thecsharper.com/?p=409"/>
    /// <see cref="http://www.codingvision.net/networking/c-simple-http-server"/>
    /// <see cref="https://gist.github.com/schneidmaster/6cb894235118ca7795eb"/>
    /// <see cref="https://gist.github.com/wqweto/f698cbe9ac8bfdbb3f300b0c4563f7e2"/>
    /// <see cref="https://gist.github.com/SimonCropp/980071"/>
    /// HTTP Server for unit testing
    /// <see cref="https://gist.github.com/yetanotherchris/fb50071bced8bf0849ecd2cbbc3e9dce"/>
    /// https://gist.github.com/ShvedAction/83385d6be12bf0836cf97336678b6547
    /// https://github.com/JamesDunne/Aardwolf
    /// https://github.com/SommerEngineering/NoIIS
    /// https://github.com/jchristn/WatsonWebserver
    /// 
    public partial class Server
    {
        public bool IsRunning
        {
            get;
            set;
        }

        public Server()
        {
            this.IsRunning = false;

            return;
        }
    }
}
