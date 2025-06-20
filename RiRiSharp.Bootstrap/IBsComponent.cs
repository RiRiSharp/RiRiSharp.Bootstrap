namespace RiRiSharp.Bootstrap;

public interface IBsComponent
{
    public string Classes { get; set; }
    public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }
}