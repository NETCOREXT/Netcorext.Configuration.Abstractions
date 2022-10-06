namespace Netcorext.Configuration.ConfigSections;

public class RabbitMqSection : ConnectionItemSection
{
    public int Port { get; set; } = 5672;
    public string VHost { get; set; } = "/";
}