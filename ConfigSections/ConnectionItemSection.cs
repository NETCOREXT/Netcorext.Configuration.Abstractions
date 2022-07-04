namespace Netcorext.Configuration.ConfigSections;

public abstract class ConnectionItemSection
{
    public string Connection { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}