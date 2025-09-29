using RiRiSharp.Bootstrap.Components.Card;
using RiRiSharp.Bootstrap.UnitTests;

namespace RiRiSharp.Bootstrap.UnitTests.Components.Card;

public class BsCardSubtitleTests() : BsComponentTests<BsCardSubtitle>("""<h6 class="card-subtitle {0}" {1}></h6>""")
{
    protected override string ClassesForDefaultTests => "card-subtitle";
    protected override Dictionary<string, string> AttributesForDefaultTests => [];
}
