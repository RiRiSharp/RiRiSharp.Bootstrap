using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Forms.InputGroup;

public partial class BsInputGroup : BsChildContentComponent
{
    [Parameter]
    public BsInputGroupSize Size { get; set; }
    protected override string BsComponentClasses => $"input-group has-validation {Size.ToBootstrapClass()}";
}
