namespace Netcorext.Configuration.Abstractions.ConfigSections;

public class ConnectionSection
{
    public Dictionary<string, RelationalDbSection> RelationalDb { get; set; }
    public Dictionary<string, MongoDbSection> MongoDb { get; set; }
    public Dictionary<string, RedisSection> Redis { get; set; }
    public Dictionary<string, RabbitMqSection> RabbitMq { get; set; }
    public Dictionary<string, ElasticsearchSection> Elasticsearch { get; set; }
    public Dictionary<string, MqttSection> Mqtt { get; set; }
}