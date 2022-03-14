using Netcorext.Configuration.Abstractions.ConfigSections;

namespace Netcorext.Configuration.Abstractions;

public abstract class Config
{
    private const string DEFAULT_VERSION = "1.0.0";

    public virtual string ConfigVersion { get; set; } = DEFAULT_VERSION;
    public virtual string Id { get; set; }
    public virtual uint MachineId { get; set; }
    public virtual uint DatacenterId { get; set; }
    public virtual string DocumentUrl { get; set; }

    public virtual Dictionary<string, OAuthSection> OAuth { get; set; }
    public virtual ConnectionSection Connections { get; set; }
    public virtual Dictionary<string, ServiceSection> Services { get; set; }
    public virtual Dictionary<string, ProxySection> Proxies { get; set; }
    public virtual Dictionary<string, string> Queues { get; set; }
    public virtual Dictionary<string, CacheSection> Caches { get; set; }
    public virtual SmtpSection Smtp { get; set; }
    public virtual SotrageSection Storage { get; set; }
}

public abstract class Config<T> : Config
{
    public virtual T AppSettings { get; set; }
}