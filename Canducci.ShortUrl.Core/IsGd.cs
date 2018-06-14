﻿using System;
using System.Threading.Tasks;
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class IsGd : ShortUrlProvider
    {
        private readonly string address = "http://is.gd/create.php?format=simple&url={0}";

        public IsGd(string url)
        {
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);                   
            Url = new Uri(url);

            Client = WebClientFactory.Create();
            Address = string.Format(address, url);

            Provider = new Provider("is.gd", new Uri("http://is.gd/"));
        }

        internal override string NormalizeContent(params string[] contents)
        {
            return JsonData.Normalize(contents[0], "");
        }

        public override string Content()
        {
            string content = Client.DownloadString(Address);
            return NormalizeContent(content);
        }

        public override async Task<string> ContentAsync()
        {            
            string content = await Client.DownloadStringTaskAsync(Address);
            return NormalizeContent(content);
        }

    }
}