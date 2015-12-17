# ShortUrl

API Site trim [https://tr.im/]

[![Canducci ShortUrl](http://i1194.photobucket.com/albums/aa377/netdragoon1/1449629657_Location%20HTTP_zpsec7muau0.png)](https://packagist.org/packages/canducci/zipcode)

[![Build status](https://ci.appveyor.com/api/projects/status/3q0thmhimm3tx6g5?svg=true)](https://ci.appveyor.com/project/netdragoon/shorturl)
[![NuGet](https://img.shields.io/nuget/dt/CanducciShortUrl.svg?style=plastic)](https://www.nuget.org/packages/CanducciShortUrl/)
[![NuGet](https://img.shields.io/nuget/v/CanducciShortUrl.svg?style=plastic)](https://www.nuget.org/packages/CanducciShortUrl/)

The package offers providers in their most current version can be selected for obtaining URL shortened. Are they:

- Bitly (https://bitly.com/)
- Googl (https://www.googleapis.com/)
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

To work to make the registration on the site and get your token, given primary for funcionalmento by that provider.

```Csharp
string url = "http://www.nuget.org";
string token = "token";
Bitly provider = new Bitly(token, url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```

- Googl (https://www.googleapis.com/)

To work to make the registration on the site and get your key, given paramount to funcionalmento by that provider.

```Csharp
string url = "http://www.nuget.org";
string key = "key";
Googl provider = new Googl(key, url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```

- IsGd (http://is.gd)

No configuration package through immediate availability of information.

```Csharp
string url = "http://www.nuget.org";
IsGd provider = new IsGd(url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```

- MigreMe (http://migre.me/)

No configuration package through immediate availability of information.

```Csharp
string url = "http://www.nuget.org";
MigreMe provider = new MigreMe(url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```

- TinyUrl (http://tinyurl.com/)

No configuration package through immediate availability of information.

```Csharp
string url = "http://www.nuget.org";
TinyUrl provider = new TinyUrl(url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```

- TrIm (https://tr.im/links)

To work to make the registration on the site and get your key, given paramount to funcionalmento by that provider.

```Csharp
string url = "http://www.nuget.org";
string key = "key";
TrIm provider = new TrIm(key, url);
ShortUrlClient client = ShortUrlClientFactory.Create(provider);
ShortUrlReceive receive = client.Receive();

```