using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardLinkTests() : BsComponentTests<BsCardLink>("""<a class="card-link {0}" {1}></a>""")
{
    protected override string ClassesForDefaultTests => "card-link";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
