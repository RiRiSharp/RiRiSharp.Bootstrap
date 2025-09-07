using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Icons;

public partial class BsIcon : ComponentBase
{
    [Parameter, EditorRequired] public string Name { get; set; }
    [Parameter] public string Classes { get; set; }
    
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalAttributes { get; set; }
}