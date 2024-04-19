namespace poc.core.api.net8.Abstractions;

/// <summary>
/// Interface marcadora para representar uma entidade.
/// </summary>
public interface IEntity
{
}

/// <summary>
/// Interface marcadora para representar uma entidade.
/// </summary>
/// <typeparam name="TKey">O tipo da chave.</typeparam>
public interface IEntity<out TKey> : IEntity where TKey : IEquatable<TKey>
{
    TKey Id { get; }
}