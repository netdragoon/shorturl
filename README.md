# ShortUrl

API Site trim [https://tr.im/]

[![Canducci ShortUrl](http://i1194.photobucket.com/albums/aa377/netdragoon1/1449629657_Location%20HTTP_zpsec7muau0.png)](https://packagist.org/packages/canducci/zipcode)

[![NuGet](https://img.shields.io/nuget/dt/CanducciShortUrl.svg?style=plastic)](https://www.nuget.org/packages/CanducciShortUrl/)
[![NuGet](https://img.shields.io/nuget/v/CanducciShortUrl.svg?style=plastic)](https://www.nuget.org/packages/CanducciShortUrl/)


Create a username and password on tr.im site. After entering the site go to Settings and ApiKey guide:

####Settings
[![Settings 1](http://i1194.photobucket.com/albums/aa377/netdragoon1/save1_zps3pixpshc.png)]()

####ApiKey
[![Settings 2](http://i1194.photobucket.com/albums/aa377/netdragoon1/save2_zpszehapgew.png)]()

##Installation NUGET


```Csharp
PM> Install-Package CanducciShortUrl

```

##How to use:

Declare o namespace `using Canducci.ShortUrl;` 


##Code:

#Simply Instance
```Csharp
string ApiKey = "";
string Url = "";

ShortUrlSend request = new ShortUrlSend(Url);
ShortUrlClient client = new ShortUrlClient(ApiKey);
ShortUrlReceive response = client.Receive(request);

//response.Keyword;
//response.ShortUrl;
//response.Url;

client.Dispose();
```
___

#Factory
```Csharp
string ApiKey = "";
string Url = "";

ShortUrlSend request = ShortUrlSendFactory.Create(Url);            
ShortUrlClient client = ShortUrlClientFactory.Create(ApiKey);            
ShortUrlReceive response = client.Receive(request);

//response.Keyword;
//response.ShortUrl;
//response.Url;

client.Dispose();
```
___

###Facade
```
string ApiKey = "";
string Url = "";

ShortUrlFacade facade = ShortUrlFactory.Create(ApiKey, Url);
ShortUrlReceive response = facade.Receive();

//response.Keyword;
//response.ShortUrl;
//response.Url;

client.Dispose();
```
