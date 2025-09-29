using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardBodyTests() : BsComponentTests<BsCardBody>("""<div class="card-body {0}" {1}></div>""")
{
    protected override string ClassesForDefaultTests => "card-body";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
