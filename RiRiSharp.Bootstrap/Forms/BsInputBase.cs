using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap.Forms;

public abstract class BsInputBase<TValue> : InputBase<TValue>, IBsComponent
{
    [Parameter] public string Classes { get; set; }

    // Use instead of CssClass, this also has the bootstrap classes.
    // Sadly the CssClass property cannot be overriden
    protected string BsCssClass
    {
        get
        {
            var bootstrapClasses = DetermineClasses();
            return BsAttributeUtilities.CombineClassNames(AdditionalAttributes, bootstrapClasses) ?? string.Empty;
        }
    }
    
    protected abstract string DetermineClasses();
}