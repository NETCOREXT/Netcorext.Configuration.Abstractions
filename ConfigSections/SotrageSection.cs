namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class SotrageSection
{
    public Dictionary<string, string> Local { get; set; }
    public GoogleCloudStorageSection GoogleCloudStorage { get; set; }
}