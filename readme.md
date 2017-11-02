
# Samples for .NET Standard

.NET Standard playground for designing several smaller libraries and utilities.

## .NET Standard links/references

Usefull links and references for porting apps to .NET Standard

*   Reverse Package Search

    http://packagesearch.azurewebsites.net/

    http://packagesearch.azurewebsites.net/?q=HttpClient

*   .NET Standard Versions

    http://immo.landwerth.net/netstandard-versions/

*   .NET API Catalog

    https://apisof.net/



## HolisticWare.Net.HTTP

HTTP client library for .NET Standard 1.0 and 1.1 intended to be integrated in Xamarin.Auth.


## 

## Motivation 

*   curl

    *   sending HTTP request to multiple Endpoints

*   Flurl - Fluent URL

    *   Fluent API

    *   avoid intentionally

        "http://xamarin.com".GetAsync();

    *   lightweight HTTP API replacement for RESTSharp et all

    *   support for .NET Standard

        *   1.0 wrapping WebRequest/HttpWebRequest and WebResponse/HttpWebResponse

            GET

            https://github.com/moljac/Samples.DotNETStandard/blob/master/source/HolisticWare.Net.OAuth.NetStandard10/Net/HTTP/Client.Requests.API.GET.cs#L22-L32

            POST

            https://github.com/moljac/Samples.DotNETStandard/blob/master/source/HolisticWare.Net.OAuth.NetStandard10/Net/HTTP/Client.Requests.API.POST.cs#L33-L51


        *   1.1 wrapping HttpClient (HttpRequestMessage and HttpResponseMessage)
            
            GET 

            https://github.com/moljac/Samples.DotNETStandard/blob/master/source/HolisticWare.Net.OAuth.NetStandard11/Net/HTTP/Client.Requests.API.GET.cs#L21-L36

            POST

            https://github.com/moljac/Samples.DotNETStandard/blob/master/source/HolisticWare.Net.OAuth.NetStandard11/Net/HTTP/Client.Requests.API.POST.cs#L33-L51

## Samples included

[INPRGORESS]

Refactored google samples for OAuth on Windows (it will use this xplat HTTP Client library):

*   https://github.com/googlesamples/oauth-apps-for-windows

*   https://github.com/googlesamples/oauth-apps-for-windows/blob/master/OAuthConsoleApp/OAuthConsoleApp/Program.cs

