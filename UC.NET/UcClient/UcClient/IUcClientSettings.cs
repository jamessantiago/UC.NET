namespace UcNetClient
{
    public interface IUcClientSettings
    {
        string Server { get; set; }

        string User { get; set; }

        string Password { get; set; }        
    }
}