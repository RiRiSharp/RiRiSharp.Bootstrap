
namespace RiRiSharp.Bootstrap.UnitTests.Forms.ChecksRadios;

// We have a partial class because of RIDER-128549
public partial class BsInputRadioTests : TestContext 
{
    private static string HtmlFormat => $$"""<input class="form-check-input {0}" type="radio" name="{{nameof(_boundValue)}}" {1}>""";
    private string _boundValue = "";
    private const string SomeValueVar = "someValue";
    private const string DifferentValueVar = "differentValue";
}