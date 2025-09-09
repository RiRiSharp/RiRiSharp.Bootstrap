using RiRiSharp.Bootstrap.Forms;

namespace RiRiSharp.Bootstrap.UnitTests.Forms;

public class BsEditFormTests() : BsComponentTests<BsEditForm>("""<form class="{0} " {1}>""")
{
    private readonly TestModel _testModel = new();
    protected override bool SkipRefCheck => true; // TODO https://github.com/RiRiSharp/RiRiSharp.Bootstrap/issues/5

    protected override void BindParameters(
        ComponentParameterCollectionBuilder<BsEditForm> parameterBuilder
    )
    {
        parameterBuilder.Add(p => p.Model, _testModel);
    }

    private class TestModel { }
}
