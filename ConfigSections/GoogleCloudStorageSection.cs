namespace Netcorext.Configuration.ConfigSections;

public class GoogleCloudStorageSection
{
    public Dictionary<string, string> Keys { get; set; }
    public Dictionary<string, BucketSection> Buckets { get; set; }
}