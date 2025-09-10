using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.InputGroup;

public partial class BsInputGroup : BsChildContentComponent
{
    [Parameter]
    public BsInputGroupSize Size { get; set; } = BsInputGroupSize.Regular;
}
