namespace RisNetClient
{
    public interface IRisClientSettings
    {
        string Server { get; set; }

        string User { get; set; }

        string Password { get; set; }
    }
}