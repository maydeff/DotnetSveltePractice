namespace Shared;

public class NoSqlSettings
{
    public const string ConfigurationKey = "Mongo";

    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;
}
