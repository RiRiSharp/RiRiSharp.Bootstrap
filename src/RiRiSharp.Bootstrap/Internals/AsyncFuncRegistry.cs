namespace RiRiSharp.Bootstrap.Internals;

public class AsyncFuncRegistry<TKey> : IAsyncFuncRegistry<TKey>
{
    private readonly Dictionary<TKey, Func<Task>> _innerRegistry = new();
    public Func<Task> this[TKey i]
    {
        get => _innerRegistry.GetValueOrDefault(i);
        set => _innerRegistry[i] = value;
    }

    public async Task ExecuteAll()
    {
        await Task.WhenAll(_innerRegistry.Select(kvp => kvp.Value.Invoke()));
    }

    public async Task Execute(TKey key)
    {
        if (_innerRegistry.TryGetValue(key, out var asyncFunc))
        {
            await asyncFunc?.Invoke();
        }
    }
}
