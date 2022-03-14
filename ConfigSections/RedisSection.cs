namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class RedisSection : ConnectionItemSection
{
    public string Instance { get; set; }
}