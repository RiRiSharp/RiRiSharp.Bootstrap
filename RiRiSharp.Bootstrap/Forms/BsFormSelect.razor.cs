using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms;

public abstract partial class BsFormSelect<TValue> : BsInputBase<TValue>
{
    [Parameter] public IEnumerable<TValue> Values { get; set; }
    [Parameter] public RenderFragment<TValue> ChildContent { get; set; }
    [Parameter] public RenderFragment Options { get; set; }
}