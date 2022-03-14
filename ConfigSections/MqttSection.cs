namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class MqttSection : ConnectionItemSection
{
    public int Port { get; set; } = 1883;
}