using Microsoft.Extensions.DependencyInjection;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Alert;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap;

public static class BsStartupExtensions
{
    public static IServiceCollection EnableJsInteractiveComponents(this IServiceCollection services)
    {
        return services
            .AddSingleton<IBsCheckboxJsFunctions, BsCheckboxJsFunctions>()
            .AddSingleton<IBsAccordionJsFunctions, BsAccordionJsFunctions>()
            .AddSingleton<IBsAlertJsFunctions, BsAlertJsFunctions>();
    }
}
