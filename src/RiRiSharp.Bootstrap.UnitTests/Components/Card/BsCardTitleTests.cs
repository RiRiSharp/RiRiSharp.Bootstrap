using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardTitleTests() : BsComponentTests<BsCardTitle>("""<h5 class="card-title {0}" {1}></h5>""")
{
    protected override string ClassesForDefaultTests => "card-title";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
