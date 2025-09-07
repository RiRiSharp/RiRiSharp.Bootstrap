namespace RiRiSharp.Bootstrap.Internals;

public interface IAsyncFuncRegistry<TKey>
{
    Task ExecuteAll();
    Task Execute(TKey key);
    Func<Task> this[TKey key] { get; set; }
}