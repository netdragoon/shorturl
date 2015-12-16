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
        public string Name { get; set; }
        public Uri Site { get; set; }
    }
}
