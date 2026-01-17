using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Forms;

public partial class BsOption<TValue> : BsChildContentComponent
{
    protected override string BsComponentClasses => "";

    [Parameter]
    public TValue? Value { get; set; }
    protected string ValueAsString => FormatValueAsString(Value);

    protected virtual string FormatValueAsString(TValue? value)
    {
        return value?.ToString() ?? "";
    }
}
