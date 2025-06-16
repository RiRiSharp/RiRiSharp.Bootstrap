using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.Forms.FormControl;

namespace RiRiSharp.Bootstrap.Forms;

public class BsInputBase<TValue> : BsComponent
{
    private const string _formControl = "form-control";

    protected TValue ValueInner;
    [Parameter] public TValue Value { get => ValueInner; set => ValueInner = value; }
    [Parameter] public EventCallback<TValue> ValueChanged { get; set; }

    protected void OnValueSet(TValue value)
    {
        if (EqualityComparer<TValue>.Default.Equals(Value, value)) return;
        ValueInner = value;

        if (!ValueChanged.HasDelegate) return;
        ValueChanged.InvokeAsync(ValueInner);
    }

    [Parameter] public FormSize FormSize { get; set; } = FormSize.Regular;

    protected string DetermineFormControlClasses()
    {
        var sizeClass = DetermineSizeClass();
        return string.Concat(' ', _formControl, sizeClass, Classes);
    }

    private string DetermineSizeClass()
    {
        return FormSize switch
        {
            FormSize.Small => "form-control-sm",
            FormSize.Regular => null,
            FormSize.Large => "form-control-lg",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}