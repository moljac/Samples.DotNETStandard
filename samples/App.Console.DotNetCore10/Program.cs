using System;
using System.Threading.Tasks;

using HolisticWare.Net.Http;

namespace App.Console.DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            OAuth2Http oauth2 = new OAuth2Http();
            Task<string> content = oauth2.HttpGetStringAsync("http://xamarin.com");

            string s = content.Result;

            System.Console.WriteLine($"Response:");
            System.Console.WriteLine($"{s}");

            return;
        }
    }
}
