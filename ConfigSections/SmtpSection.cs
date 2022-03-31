namespace Netcorext.Configuration.ConfigSections;

public class SmtpSection
{
    public string Host { get; set; }
    public int Port { get; set; } = 25;
    public bool EnableSsl { get; set; }
    public string FromAddress { get; set; }
    public string FromDisplayName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}