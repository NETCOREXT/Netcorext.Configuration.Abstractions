namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class MongoDbSection : ConnectionItemSection
{
    public string Database { get; set; }
}