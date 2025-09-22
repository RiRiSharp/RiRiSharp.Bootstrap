using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using RiRiSharp.Bootstrap.Components.Accordion.Internals;
using RiRiSharp.Bootstrap.Components.Alert.Internals;
using RiRiSharp.Bootstrap.Components.Buttons.Internals;
using RiRiSharp.Bootstrap.Forms.ChecksRadios.Internals;
using RiRiSharp.Bootstrap.Internals;

namespace RiRiSharp.Bootstrap;

public static class BsStartupExtensions
{
    public static IServiceCollection EnableJsInteractiveComponents(this IServiceCollection services)
    {
        return services
            .AddBootstrapJs<IBsAccordionJsFunctions, BsAccordionJsFunctions>()
            .AddBootstrapJs<IBsAlertJsFunctions, BsAlertJsFunctions>()
            .AddBootstrapJs<IBsButtonJsFunctions, BsButtonJsFunctions>()
            .AddBootstrapJs<IBsCheckboxJsFunctions, BsCheckboxJsFunctions>();
    }

    private static IServiceCollection AddBootstrapJs<TService, TImpl>(this IServiceCollection services)
        where TService : class
        where TImpl : class, TService, IBsJsFunctionsWrapper
    {
        var filePath = $"./_content/{typeof(TImpl).Assembly.GetName().Name}/js/{TImpl.JsFileName}";
        return services.AddSingleton<TService>(sp =>
        {
            var jsRuntime = sp.GetRequiredService<IJSRuntime>();
            var bsJsObjectRef = new BsJsObjectReference(jsRuntime, filePath);
            return ActivatorUtilities.CreateInstance<TImpl>(sp, bsJsObjectRef);
        });
    }
}
