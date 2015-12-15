namespace Canducci.ShortUrl
{
    public struct Provider
    {
        public Provider(string name, string site)
        {
            Name = name;
            Site = site;
        }
        public string Name { get; set; }
        public string Site { get; set; }
    }
}
