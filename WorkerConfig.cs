using Netcorext.Configuration.ConfigSections;

namespace Netcorext.Configuration;

public abstract class WorkerConfig : Config
{
    public virtual TaskSection Task { get; set; }
}

public abstract class WorkerConfig<T> : Config<T>
{
    public virtual TaskSection Task { get; set; }
}