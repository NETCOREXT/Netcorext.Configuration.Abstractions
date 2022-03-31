namespace Netcorext.Configuration.ConfigSections;

public class CacheSection
{
    public int? ServerDuration { get; set; }
    public int? ClientDuration { get; set; }
    public bool? ClientNoStore { get; set; }
}