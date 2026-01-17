using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;
using Wader.Internals;

namespace Wader.Components.Modal;

public partial class BsModalTitle : BsChildContentComponent
{
    protected override string BsComponentClasses => "modal-title";

    [Parameter]
    public int Heading { get; set; } = 5;
}
