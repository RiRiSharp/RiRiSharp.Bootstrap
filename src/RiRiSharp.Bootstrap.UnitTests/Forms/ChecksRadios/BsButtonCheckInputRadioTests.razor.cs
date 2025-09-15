using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public partial class BsButtonCheckInputRadioTests : BsComponentTests<BsButtonCheckInputRadio<string>>
{
    private string? _boundValue = "";
    private const string SOME_VALUE_VAR = "someValue";
    private const string DIFFERENT_VALUE_VAR = "differentValue";

    public BsButtonCheckInputRadioTests()
        : base($$"""<input class="btn-check {0}" type="radio" name="{{nameof(_boundValue)}}" {1}>""") { }

    [Fact]
    public void MatchingValuesChecksTheRadio()
    {
        // Arrange
        _boundValue = SOME_VALUE_VAR;

        // Act
        var cut = GetCut(parameters => parameters.Add(p => p.Value, SOME_VALUE_VAR));

        // Assert
        // One might ask why a? And there's a (no pun intended) super obscure reason for it.
        // This can be found here: https://github.com/dotnet/aspnetcore/blob/main/src/Components/Web/src/Forms/InputRadio.cs#L78-L95
        var expectedMarkupString = GetExpectedHtml("", $"""value="{SOME_VALUE_VAR}" checked="a" """);
        cut.MarkupMatches(expectedMarkupString);
    }

    protected override IRenderedComponent<BsButtonCheckInputRadio<string>> GetCut(
        Action<ComponentParameterCollectionBuilder<BsButtonCheckInputRadio<string>>>? action = null
    )
    {
        var inputGroupComponent = Render<BsInputRadioGroup<string>>(parameters =>
        {
            _ = parameters
                .Add(p => p.Name, nameof(_boundValue))
                .Bind(p => p.Value, _boundValue, newValue => _boundValue = newValue)
                .AddChildContent<BsButtonCheckInputRadio<string>>(pms =>
                {
                    BindParameters(pms);
                    action?.Invoke(pms);
                });
        });
        return inputGroupComponent.FindComponent<BsButtonCheckInputRadio<string>>();
    }
}
