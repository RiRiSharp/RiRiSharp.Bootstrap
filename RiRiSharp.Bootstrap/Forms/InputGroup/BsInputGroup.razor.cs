using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms.InputGroups;

public partial class BsInputGroup : BsChildContentComponent
{
    [Parameter] public InputGroupSize Size { get; set; } = InputGroupSize.Regular;
}