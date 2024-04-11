﻿namespace Poc.Api.Extensions;
public static class HealthCheckTags
{
    public static readonly string[] DatabaseTags = new[] { "database_tag" };
    public static readonly string[] CacheTags = new[] { "cache_tag" };
    //public static readonly string[] RabbitMqTags = new[] { "rabbitmq_tag" };
    public static readonly string[] RabbitMqTags = new[] { "rabbitmq" };
}