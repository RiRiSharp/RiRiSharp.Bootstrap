using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.Helpers;

public partial class DisplayFlex : BsChildContentComponent
{
    [Parameter] public Justification Justify { get; set; }

    public virtual string JustificationClass()
    {
        return Justify switch
        {
            Justification.Start => "justify-content-start",
            Justification.End => "justify-content-end",
            Justification.Center => "justify-content-center",
            Justification.Between => "justify-content-between",
            Justification.Around => "justify-content-around",
            Justification.Evenly => "justify-content-evenly",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}