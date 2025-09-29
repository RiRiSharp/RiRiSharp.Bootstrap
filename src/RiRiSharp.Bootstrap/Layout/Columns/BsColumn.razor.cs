﻿using Microsoft.AspNetCore.Components;
using RiRiSharp.Bootstrap.BaseComponents;

namespace RiRiSharp.Bootstrap.Layout.Columns;

public partial class BsColumn : BsChildContentComponent
{
    protected override string BsComponentClasses =>
        $"{ColumnOptionsBootstrapClasses()} {ColumnOffsetBootstrapClasses()} {ColumnOrder.ToBootstrapClass()}";

    [Parameter]
    public BsColumnOptions ColOption { get; set; }

    [Parameter]
    public IEnumerable<BsColumnOptions> ColOptions { get; set; } = [];

    [Parameter]
    public BsColumnOptions OffsetOption { get; set; }

    [Parameter]
    public IEnumerable<BsColumnOptions> OffsetOptionsList { get; set; } = [];

    [Parameter]
    public BsColumnOrder ColumnOrder { get; set; }

    private string ColumnOptionsBootstrapClasses()
    {
        var colOptionsList = ColOptions.ToList();
        if (colOptionsList.Count == 0)
        {
            return ColOption.ToBootstrapColClass();
        }

        var classes = colOptionsList.Select(b => b.ToBootstrapColClass());
        return string.Join(' ', classes);
    }

    private string ColumnOffsetBootstrapClasses()
    {
        var offsetOptionsList = OffsetOptionsList.ToList();
        if (offsetOptionsList.Count == 0)
        {
            return OffsetOption.ToBootstrapOffsetClass();
        }

        var classes = offsetOptionsList.Select(b => b.ToBootstrapOffsetClass());
        return string.Join(' ', classes);
    }
}
