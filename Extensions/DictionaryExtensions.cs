using Netcorext.Configuration.ConfigSections;

namespace Netcorext.Configuration.Extensions;

public static class DictionaryExtensions
{
    public const string KEY_DEFAULT = "Default";

    public static RelationalDbSection? GetDefault(this Dictionary<string, RelationalDbSection> section)
    {
        return section.TryGetValue(KEY_DEFAULT, out var result) ? result : null;
    }

    public static MongoDbSection? GetDefault(this Dictionary<string, MongoDbSection> section)
    {
        return section.TryGetValue(KEY_DEFAULT, out var result) ? result : null;
    }

    public static RedisSection? GetDefault(this Dictionary<string, RedisSection> section)
    {
        return section.TryGetValue(KEY_DEFAULT, out var result) ? result : null;
    }

    public static RabbitMqSection? GetDefault(this Dictionary<string, RabbitMqSection> section)
    {
        return section.TryGetValue(KEY_DEFAULT, out var result) ? result : null;
    }

    public static ElasticsearchSection? GetDefault(this Dictionary<string, ElasticsearchSection> section)
    {
        return section.TryGetValue(KEY_DEFAULT, out var result) ? result : null;
    }

    public static MqttSection? GetDefault(this Dictionary<string, MqttSection> section)
    {
        return section.TryGetValue(KEY_DEFAULT, out var result) ? result : null;
    }
}