using Microsoft.AspNetCore.Components;
using Wader.BaseComponents;

namespace Wader.Icons;

public partial class BsIcon : BsComponent
{
    protected override string BsComponentClasses => $"bi {Name}";

    [Parameter, EditorRequired]
    public string Name { get; set; }
}
