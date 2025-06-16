using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap;

public class BsComponent : ComponentBase
{
    [Parameter] public string Classes { get; set; }
    
    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object> AdditionalAttributes { get; set; }
}