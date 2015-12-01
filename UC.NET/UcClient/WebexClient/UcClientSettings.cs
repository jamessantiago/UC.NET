namespace UcNetClient
{
    public class WebexClientSettings : IUcClientSettings
    {
        public string Server { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public long SiteId { get; set; }

        public string PartnetId { get; set; }

        public string Email { get; set; }
    }
}