using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Forms.Select;


// 'multiple' is not supported (yet)
public abstract partial class BsFormSelect<TValue> : BsInputBase<TValue>
{
    private const string _formSelect = "form-select";
    [Parameter] public IEnumerable<TValue> Values { get; set; }
    [Parameter] public FormSize FormSize { get; set; }
    [Parameter] public RenderFragment<TValue> ChildContent { get; set; }
    [Parameter] public RenderFragment Options { get; set; }

    protected override string DetermineClasses()
    {
        var sizeClass = DetermineSizeClass();
        return string.Join(' ', _formSelect, sizeClass, Classes);
    }

    private string DetermineSizeClass()
    {
        if (FormSize == FormSize.Regular) return "";
        if (FormSize == FormSize.Small) return $"{_formSelect}-sm";
        if (FormSize == FormSize.Large) return $"{_formSelect}-lg";
        
        throw new ArgumentOutOfRangeException(nameof(FormSize));
    }
}