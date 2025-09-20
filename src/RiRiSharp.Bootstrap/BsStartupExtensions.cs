using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Components.Accordion;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Components.Alert;
using RiRiSharp.Bootstrap.Forms.ChecksRadios;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap;

public static class BsStartupExtensions
{
    public static IServiceCollection EnableJsInteractiveComponents(this IServiceCollection services)
    {
        return services
            .AddBootstrapJs<IBsCheckboxJsFunctions, BsCheckboxJsFunctions>(
                $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{BsCheckboxJsFunctions.JS_FILE_NAME}"
            )
            .AddBootstrapJs<IBsAccordionJsFunctions, BsAccordionJsFunctions>(
                $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{BsAccordionJsFunctions.JS_FILE_NAME}"
            )
            .AddBootstrapJs<IBsAlertJsFunctions, BsAlertJsFunctions>(
                $"./_content/{typeof(BsCheckboxJsFunctions).Assembly.GetName().Name}/js/{BsAlertJsFunctions.JS_FILE_NAME}"
            );
    }

    private static IServiceCollection AddBootstrapJs<TService, TImpl>(
        this IServiceCollection services,
        string jsFilePath
    )
        where TService : class
        where TImpl : class, TService
    {
        return services.AddSingleton<TService>(sp =>
        {
            var jsRuntime = sp.GetRequiredService<IJSRuntime>();
            var bsJsObjectRef = new BsJsObjectReference(jsRuntime, jsFilePath);
            return ActivatorUtilities.CreateInstance<TImpl>(sp, bsJsObjectRef);
        });
    }
}
