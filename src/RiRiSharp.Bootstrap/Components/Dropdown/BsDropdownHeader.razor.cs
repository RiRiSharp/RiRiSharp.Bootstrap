using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Dropdown;

public partial class BsDropdownHeader : BsChildContentComponent
{
    protected override string BsComponentClasses => "dropdown-header";
    public override ElementReference HtmlRef => _bsHeadingRef!.HtmlRef;

    [Parameter]
    public int Heading { get; set; } = 6;

#pragma warning disable IDE0044
    /// <summary>
    /// We disable this rule 'cause the IDE doesn't seem to understand that Blazor does write to this attribute
    /// </summary>
    private BsHeading? _bsHeadingRef;
#pragma warning restore IDE0044
}
