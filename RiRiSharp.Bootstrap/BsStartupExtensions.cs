using Microsoft.Extensions.DependencyInjection;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;

namespace RiRiSharp.Bootstrap;

public static class BsStartupExtensions
{
    public static IServiceCollection EnableJsInteractiveComponents(this IServiceCollection services)
    {
        services.AddSingleton<IBsCheckboxJsFunctions, BsCheckboxJsFunctions>();
        return services;
    }
}