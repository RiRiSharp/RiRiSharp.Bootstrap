using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Components.Modal;

public partial class BsModalTitle : BsChildContentComponent
{
    protected override string BsComponentClasses => "modal-title";
    public override ElementReference HtmlRef => _bsHeadingRef!.HtmlRef;

    [Parameter]
    public int Heading { get; set; } = 5;

#pragma warning disable IDE0044
    /// <summary>
    /// We disable this rule 'cause the IDE doesn't seem to understand that Blazor does write to this attribute
    /// </summary>
    private BsHeading? _bsHeadingRef;
#pragma warning restore IDE0044
}
