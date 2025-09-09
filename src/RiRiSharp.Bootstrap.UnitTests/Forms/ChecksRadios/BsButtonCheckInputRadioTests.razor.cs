using RiRiSharp.Bootstrap.Forms.ChecksRadios;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

// We have a partial class because of RIDER-128549
public partial class BsButtonCheckInputRadioTests : BsComponentTests<BsButtonCheckInputRadio<string>>
{
    private string _boundValue = "";
    private const string _someValueVar = "someValue";
    private const string _differentValueVar = "differentValue";
    
    public BsButtonCheckInputRadioTests() : base(
        $$"""<input class="btn-check {0}" type="radio" name="{{nameof(_boundValue)}}" {1}>""")
    {
        
    }
    
    [Fact]
    public void MatchingValuesChecksTheRadio()
    {
        // Arrange
        _boundValue = _someValueVar;

        // Act
        var cut = GetCut(parameteters => parameteters.Add(p => p.Value, _someValueVar));

        // Assert
        // One might ask why a? And there's a (no pun intended) super obscure reason for it.
        // This can be found here: https://github.com/dotnet/aspnetcore/blob/main/src/Components/Web/src/Forms/InputRadio.cs#L78-L95
        var expectedMarkupString = GetExpectedHtml("", $"""value="{_someValueVar}" checked="a" """);
        cut.MarkupMatches(expectedMarkupString);
    }
    
    protected override IRenderedComponent<BsButtonCheckInputRadio<string>> GetCut(
        Action<ComponentParameterCollectionBuilder<BsButtonCheckInputRadio<string>>> action = null)
    {
        var inputGroupComponent = Render<BsInputRadioGroup<string>>(parameters =>
        {
            parameters.Add(p => p.Name, nameof(_boundValue));
            parameters.Bind(p => p.Value, _boundValue, newValue => _boundValue = newValue);
            parameters.AddChildContent<BsButtonCheckInputRadio<string>>(pms =>
            {
                BindParameters(pms);
                action?.Invoke(pms);
            });
        });
        return inputGroupComponent.FindComponent<BsButtonCheckInputRadio<string>>();
    }
}