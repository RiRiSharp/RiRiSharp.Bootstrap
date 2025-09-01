using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.BsHelpers;

public partial class DisplayFlex : BsChildContentComponent
{
    [Parameter] public Justification Justify { get; set; }
}