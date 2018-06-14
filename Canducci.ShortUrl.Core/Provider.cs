using System;
namespace Canducci.ShortUrl
{
    public struct Provider
    {
        public Provider(string name, Uri site)
        {
            Name = name;
            Site = site;
        }
        public Provider(string name, string site)
            :this(name, new Uri(site))
        {            
        }

        public string Name { get; set; }
        public Uri Site { get; set; }
    }
}
