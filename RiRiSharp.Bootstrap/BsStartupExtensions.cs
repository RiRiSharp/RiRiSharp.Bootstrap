using Microsoft.Extensions.DependencyInjection;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap;

public static class BsStartupExtensions
{
    public static IServiceCollection EnableJsInteractiveComponents(this IServiceCollection services)
    {
        services.AddSingleton<IBsCheckboxJsFunctions, BsCheckboxJsFunctions>();
        services.AddSingleton<IBsAccordionJsFunctions, BsAccordionJsFunctions>();
        return services;
    }
}