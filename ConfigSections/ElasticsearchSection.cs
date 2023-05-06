namespace Netcorext.Configuration.ConfigSections;

public class ElasticsearchSection : ConnectionItemSection
{
    public string CloudId { get; set; }
    public string Index { get; set; }
}