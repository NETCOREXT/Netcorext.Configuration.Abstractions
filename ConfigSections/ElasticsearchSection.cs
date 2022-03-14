namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class ElasticsearchSection : ConnectionItemSection
{
    public string Index { get; set; }
}