using System;
using System.Threading.Tasks;
using ClassesToTest.Shared.DotNetStandard1_0;

namespace App.Console.DotNetCore20
{
    class Program
    {
        static void Main(string[] args)
        {
            OAuth2Http oauth2 = new OAuth2Http();
            Task<string> content = oauth2.HttpGetAsync("http://xamarin.com");

            string s = content.Result;

            return;
        }
    }
}
