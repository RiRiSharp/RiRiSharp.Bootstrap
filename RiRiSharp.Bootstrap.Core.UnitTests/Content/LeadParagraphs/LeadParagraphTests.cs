using RiRiSharp.Bootstrap.Core.Content.Abbreviations;
using RiRiSharp.Bootstrap.Core.Content.LeadParagraphs;

namespace RiRiSharp.Bootstrap.Core.UnitTests.Content.LeadParagraphs;

public class LeadParagraphTests() : BootstrapCoreComponentTests<LeadParagraph>(@"<p class=""lead {0}"" {1}></p>");