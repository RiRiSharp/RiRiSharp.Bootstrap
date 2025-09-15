using System;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

public partial class BsInputRadioTests : BsComponentTests<BsInputRadio<string>>
{
    private string? _boundValue = "";
    private const string SOME_VALUE_VAR = "someValue";
    private const string DIFFERENT_VALUE_VAR = "differentValue";

    public BsInputRadioTests()
        : base($$"""<input class="form-check-input {0}" type="radio" name="{{nameof(_boundValue)}}" {1}>""") { }

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

    protected override IRenderedComponent<BsInputRadio<string>> GetCut(
        Action<ComponentParameterCollectionBuilder<BsInputRadio<string>>>? action = null
    )
    {
        var inputGroupComponent = Render<BsInputRadioGroup<string>>(parameters =>
        {
            _ = parameters
                .Add(p => p.Name, nameof(_boundValue))
                .Bind(p => p.Value, _boundValue, newValue => _boundValue = newValue)
                .AddChildContent<BsInputRadio<string>>(pms =>
                {
                    BindParameters(pms);
                    action?.Invoke(pms);
                });
        });
        return inputGroupComponent.FindComponent<BsInputRadio<string>>();
    }
}
