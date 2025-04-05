using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Core;

public class BootstrapCoreComponent : ComponentBase
{
    [Parameter] public string Classes { get; set; }
    
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalAttributes { get; set; }
}