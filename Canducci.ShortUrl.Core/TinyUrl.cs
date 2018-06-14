﻿using System;
using System.Threading.Tasks;
namespace Canducci.ShortUrl
{
    [Serializable()]
    public sealed class TinyUrl : ShortUrlProvider
    {
        private readonly string address = "http://tinyurl.com/api-create.php?url={0}";

        public TinyUrl(string url)
        { 
            Validation.IsUrl(url, Message.MessageUrlIsInvalid);
            Url = new Uri(url);

            Client = WebClientFactory.Create();
            Address = string.Format(address, url);

            Provider = new Provider("tinyurl", new Uri("http://tinyurl.com"));
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