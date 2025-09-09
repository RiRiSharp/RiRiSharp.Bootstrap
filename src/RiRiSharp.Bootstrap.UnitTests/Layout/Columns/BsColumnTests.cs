using RiRiSharp.Bootstrap.Layout.Columns;

namespace RiRiSharp.Bootstrap.UnitTests.Layout.Columns;

public class BsColumnTests() : BsComponentTests<BsColumn>("""<div class="col {0}" {1}></div>""")
{
    [Fact]
    public void ColumnRenderingWorksInSingularForm()
    {
        // Arrange + Act
        var cut = GetCut(parameters => parameters.Add(p => p.ColOption, BsColumnOptions.Col1));

        // Assert
        cut.MarkupMatches("""<div class="col-1"></div>""");
    }

    [Fact]
    public void ColumnRenderingWorksInListForm()
    {
        // Arrange + Act
        var cut = GetCut(parameters =>
            parameters.Add(p => p.ColOptionsList, [BsColumnOptions.ColSm4, BsColumnOptions.ColMd6])
        );

        // Assert
        cut.MarkupMatches("""<div class="col-sm-4 col-md-6"></div>""");
    }

    [Fact]
    public void ListColumnOptionTakesPrecedenceOverSingularForm()
    {
        var cut = GetCut(parameters =>
            parameters
                .Add(p => p.ColOption, BsColumnOptions.Col1)
                .Add(p => p.ColOptionsList, [BsColumnOptions.ColSm4, BsColumnOptions.ColMd6])
        );

        cut.MarkupMatches("""<div class="col-sm-4 col-md-6"></div>""");
    }

    [Fact]
    public void ColumnOffsetRenderingWorksInSingularForm()
    {
        var cut = GetCut(parameters => parameters.Add(p => p.OffsetOption, BsColumnOptions.Col1));

        cut.MarkupMatches(GetExpectedHtml("offset-1", ""));
    }

    [Fact]
    public void ColumnOffsetRenderingWorksInListForm()
    {
        var cut = GetCut(parameters =>
            parameters.Add(
                p => p.OffsetOptionsList,
                [BsColumnOptions.ColSm4, BsColumnOptions.ColMd6]
            )
        );

        cut.MarkupMatches(GetExpectedHtml("offset-sm-4 offset-md-6", ""));
    }

    [Fact]
    public void ListColumnOffsetOptionTakesPrecedenceOverSingularForm()
    {
        var cut = GetCut(parameters =>
            parameters
                .Add(p => p.OffsetOption, BsColumnOptions.Col1)
                .Add(p => p.OffsetOptionsList, [BsColumnOptions.ColSm4, BsColumnOptions.ColMd6])
        );

        cut.MarkupMatches(GetExpectedHtml("offset-sm-4 offset-md-6", ""));
    }
}
