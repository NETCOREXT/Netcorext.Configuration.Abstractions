using Netcorext.Configuration.Abstractions.ConfigSections;

namespace Netcorext.Configuration.Abstractions;

public abstract class WorkerConfig : Config
{
    public virtual TaskSection Task { get; set; }
}

public abstract class WorkerConfig<T> : Config<T>
{
    public virtual TaskSection Task { get; set; }
}