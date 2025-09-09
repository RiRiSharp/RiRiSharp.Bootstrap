using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.Forms;
using RiRiSharp.Bootstrap.Forms.Validation;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.Validation;

public class BsValidationMessageTests : BunitContext
{
    private const string _errorMessage = "Error message";
    private readonly TestModel _model;
    private readonly EditContext _editContext;
    private IRenderedComponent<BsEditForm> _editContextComponent;

    [StringSyntax("Html")]
    private const string _htmlFormat =
        $$"""<div class="invalid-feedback {0}" {1}>{{_errorMessage}}</div>""";

    private Action<
        ComponentParameterCollectionBuilder<BsValidationMessage<string>>
    > DefaultAction => parameters => parameters.Add(p => p.For, () => _model.Property);

    public BsValidationMessageTests()
    {
        _model = new TestModel();
        _editContext = new EditContext(_model);
    }

    private IRenderedComponent<BsValidationMessage<string>> GetCut(
        Action<ComponentParameterCollectionBuilder<BsValidationMessage<string>>> builder = null
    )
    {
        var builderAction = DefaultAction + builder;
        _editContextComponent = Render<BsEditForm>(parameters =>
            parameters
                .Add(p => p.EditContext, _editContext)
                .Add(p => p.ChildContent, _ => builderAction)
        );

        return _editContextComponent.FindComponent<BsValidationMessage<string>>();
    }

    [Fact]
    public async Task DefaultWorks()
    {
        // Arrange
        var cut = GetCut();

        // Act
        await SimulateValidatingModel();

        // Assert
        var expectedMarkupString = string.Format(_htmlFormat, "", "");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("aclass")]
    [InlineData("aclass bclass")]
    [InlineData("aclass blass class")]
    public async Task PassingClassesWorks(string classes)
    {
        // Arrange
        var cut = GetCut(parameters =>
        {
            parameters.Add(x => x.Classes, classes);
        });

        // Act
        await SimulateValidatingModel();

        // Assert
        var expectedMarkupString = string.Format(_htmlFormat, classes, "");
        cut.MarkupMatches(expectedMarkupString);
    }

    [Theory]
    [InlineData(
        new[] { "attributeKey" },
        new[] { "attributeValue" },
        """
            attributeKey="attributeValue"
            """
    )]
    [InlineData(
        new[] { "attributeKey1", "attributeKey2" },
        new[] { "attributeValue1", "attributeValue2" },
        """
            attributeKey1="attributeValue1" attributeKey2="attributeValue2"
            """
    )]
    public async Task ExtraAttributesWorks(
        string[] attributeKeys,
        string[] attributeValues,
        string expected
    )
    {
        // Arrange
        var cut = GetCut(parameters =>
        {
            for (var i = 0; i < attributeKeys.Length; i++)
            {
                parameters.AddUnmatched(attributeKeys[i], attributeValues[i]);
            }
        });

        // Act
        await SimulateValidatingModel();

        // Assert
        var expectedMarkupString = string.Format(_htmlFormat, "", expected);
        cut.MarkupMatches(expectedMarkupString);
    }

    private async Task SimulateValidatingModel()
    {
        // We need to make sure an error happened so we make the validation message actually appear
        var store = new ValidationMessageStore(_editContext);
        var field = FieldIdentifier.Create(() => _model.Property);
        store.Clear(field);
        store.Add(field, _errorMessage);
        await _editContextComponent.InvokeAsync(_editContext.NotifyValidationStateChanged);
    }

    private class TestModel
    {
        public string Property { get; set; }
    }
}
