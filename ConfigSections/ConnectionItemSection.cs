namespace Netcorext.Configuration.ConfigSections;

public abstract class ConnectionItemSection
{
    public string Connection { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int PoolSize { get; set; } = Config.DEFAULT_POOL_SIZE;
    public int DataSizeLimit { get; set; } = Config.DEFAULT_DATA_SIZE_LIMIT;
}