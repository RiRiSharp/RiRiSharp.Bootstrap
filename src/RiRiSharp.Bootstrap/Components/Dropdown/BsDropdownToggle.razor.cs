using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Components.Buttons;

namespace RiRiSharp.Bootstrap.Components.Dropdown;

public partial class BsDropdownToggle : BsChildContentComponent
{
    protected override string BsComponentClasses => $"dropdown-toggle {ModeClass}";

    public override ElementReference HtmlRef => _bsButtonRef!.HtmlRef;

    [CascadingParameter]
    public BsDropdownMode Mode { get; set; }

    private string ModeClass => Mode.ToBootstrapButtonClass();

    [Parameter]
    public BsButtonSize Size { get; set; }

    [Parameter]
    public BsButtonVariant Variant { get; set; } = BsButtonVariant.Primary;

#pragma warning disable IDE0044
    /// <summary>
    /// We disable this rule 'cause the IDE doesn't seem to understand that Blazor does write to this attribute
    /// </summary>
    private BsButton? _bsButtonRef;
#pragma warning restore IDE0044
}
