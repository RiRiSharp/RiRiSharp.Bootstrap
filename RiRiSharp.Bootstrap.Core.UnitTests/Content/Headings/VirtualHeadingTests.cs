using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.Headings;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.Headings;

public class VirtualHeadingTests() : BootstrapCoreComponentTests<VirtualHeading>(@"<span class=""h1 {0}"" {1}></span>");