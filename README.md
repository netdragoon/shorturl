# ShortUrl

API Site trim [https://tr.im/]

[![Canducci ShortUrl](http://i1194.photobucket.com/albums/aa377/netdragoon1/1449629657_Location%20HTTP_zpsec7muau0.png)](https://packagist.org/packages/canducci/zipcode)

[![Build status](https://ci.appveyor.com/api/projects/status/3q0thmhimm3tx6g5?svg=true)](https://ci.appveyor.com/project/netdragoon/shorturl)
[![NuGet](https://img.shields.io/nuget/dt/CanducciShortUrl.svg?style=plastic)](https://www.nuget.org/packages/CanducciShortUrl/)
[![NuGet](https://img.shields.io/nuget/v/CanducciShortUrl.svg?style=plastic)](https://www.nuget.org/packages/CanducciShortUrl/)

The package offers providers in their most current version can be selected for obtaining URL shortened. Are they:

- Bitly (https://bitly.com/)
- Googl (https://developers.google.com/url-shortener/v1/getting_started)
- IsGd (http://is.gd)
- MigreMe (http://migre.me/)
- TinyUrl (http://tinyurl.com/)
- TrIm (https://tr.im/links)

All of these providers work in a clear and objective manner to generate the urls.

####Nuget installation

```Csharp
PM> Install-Package CanducciShortUrl

```

####How to use:

Declare o namespace `using Canducci.ShortUrl;` 


####Code:

The only difference now is that first of all must choose each providers offered for the SHORTURL make the obtaining of the information operations. It will be shown each logo below:

- Bitly (https://bitly.com/)

__To work to make the registration on the site and get your token, given primary for funcionalmento by that provider.__

```Csharp
string url = "http://www.nuget.org";
string token = "token";
Bitly provider = new Bitly(token, url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```
__Example:__ Create a ___username___ and ___password___ and get your token.

>![Bitly](http://i1308.photobucket.com/albums/s610/maryjanexique/bitly_zpssd3crt8q.png)

___

__Googl__ (https://developers.google.com/url-shortener/v1/getting_started)

__To work to make the registration on the site and get your key, given paramount to funcionalmento by that provider.__

```Csharp
string url = "http://www.nuget.org";
string key = "key";
Googl provider = new Googl(key, url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```
__Example:__ Create a ___username___ and ___password___. Link to more information: (https://support.google.com/cloud/answer/6158862?hl=en&ref_topic=6262490)
___

__IsGd__ (http://is.gd)

__No configuration package through immediate availability of information.__

```Csharp
string url = "http://www.nuget.org";
IsGd provider = new IsGd(url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```
___

__MigreMe__ (http://migre.me/)

__No configuration package through immediate availability of information.__

```Csharp
string url = "http://www.nuget.org";
MigreMe provider = new MigreMe(url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```
___

__TinyUrl__ (http://tinyurl.com/)

__No configuration package through immediate availability of information.__

```Csharp
string url = "http://www.nuget.org";
TinyUrl provider = new TinyUrl(url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```
___

__TrIm__ (https://tr.im/links)

__To work to make the registration on the site and get your key, given paramount to funcionalmento by that provider.__

```Csharp
string url = "http://www.nuget.org";
string key = "key";
TrIm provider = new TrIm(key, url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```

__Example:__ Create a ___username___ and ___password___ on [tr.im](http://tr.im) site. After entering the site go to __Settings__ and __ApiKey__ guide:

####Settings

>[![Settings 1](http://i1194.photobucket.com/albums/aa377/netdragoon1/save1_zps3pixpshc.png)]()

####ApiKey
>[![Settings 2](http://i1194.photobucket.com/albums/aa377/netdragoon1/save2_zpszehapgew.png)]()

The ApiKey your account [tr.im](http://tr.im) site is responsible for the integration with the code, as in the example below the variable `string ApiKey` and variable `string url` any valid internet address.

___

The providers __TinyUrl__, __MigreMe__ e __IsGd__  do not need any related token or key settings are simpler and just need the url to generate a short url.

__Note:__

- remember that the async methods (`ReceiveAsync`) are present as the .NET Framework version (> = 4.5).

___

####Old Version

The old version only works with trim and are in that link your settings (https://github.com/netdragoon/shorturl/blob/master/README001002.md)