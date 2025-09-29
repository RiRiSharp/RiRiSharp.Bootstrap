using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardHeaderTitleTests() : BsComponentTests<BsCardHeaderTitle>("""<h5 class="card-header {0}" {1}></h5>""")
{
    protected override string ClassesForDefaultTests => "card-header";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
