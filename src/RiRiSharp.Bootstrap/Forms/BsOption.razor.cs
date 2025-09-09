using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Forms;

public partial class BsOption<TValue> : BsChildContentComponent
{
    [Parameter]
    public TValue Value { get; set; }
    protected string ValueAsString => FormatValueAsString(Value);

    protected virtual string FormatValueAsString(TValue value) => value?.ToString();
}
