namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class RabbitMqSection : ConnectionItemSection
{
    public int Port { get; set; } = 5672;
    public string VHost { get; set; } = "/";
    public string Username { get; set; }
    public string Password { get; set; }
}