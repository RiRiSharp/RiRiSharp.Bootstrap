using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Helpers;

public partial class DisplayFlex : BsChildContentComponent
{
    [Parameter] public Justification Justify { get; set; }
}