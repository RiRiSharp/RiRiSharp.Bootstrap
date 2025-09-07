namespace RiRiSharp.Bootstrap.BaseComponents;

public interface IBsComponent
{
    public string Classes { get; set; }
    public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }
}