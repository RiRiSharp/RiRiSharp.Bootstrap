using Microsoft.AspNetCore.Components;

namespace RiRiSharp.Bootstrap.UnitTests.Forms.FormControl;

public partial class BsInputFileTests : ComponentBase
{
    private static string HtmlFormat => """<input class="form-control {0}" type="file" {1}>""";
}