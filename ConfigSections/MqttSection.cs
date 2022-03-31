namespace Netcorext.Configuration.ConfigSections;

public class MqttSection : ConnectionItemSection
{
    public int Port { get; set; } = 1883;
}