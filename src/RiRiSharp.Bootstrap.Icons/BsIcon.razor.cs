using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Icons;

public partial class BsIcon : BsComponent
{
    protected override string BsComponentClasses => $"bi {Name}";

    [Parameter, EditorRequired]
    public string Name { get; set; }
}
