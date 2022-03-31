namespace Netcorext.Configuration.ConfigSections;

public class TaskSection
{
    public int WorkerDelay { get; set; } = 3000;
    public int TaskDelay { get; set; } = 3000;
    public int TaskLimitCount { get; set; } = 1;
}