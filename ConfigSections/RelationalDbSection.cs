namespace Netcorext.Configuration.ConfigSections;

public class RelationalDbSection : ConnectionItemSection
{
    public bool? EnableDetailedErrors { get; set; }
    public bool? EnableSensitiveDataLogging { get; set; }
    public bool? EnableServiceProviderCaching { get; set; }
    public bool? EnableThreadSafetyChecks { get; set; }
}
