using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Wader.Components.Accordion.Internals;
using Wader.Components.Alert.Internals;
using Wader.Components.Buttons.Internals;
using Wader.Components.Carousel.Internals;
using Wader.Components.Collapse.Internals;
using Wader.Components.Modal.Internals;
using Wader.Forms.ChecksRadios.Internals;
using Wader.Internals;

namespace Wader;

public static class BsStartupExtensions
{
    public static IServiceCollection EnableJsInteractiveComponents(this IServiceCollection services)
    {
        return services
            .AddBootstrapJs<IBsAccordionJsFunctions, BsAccordionJsFunctions>()
            .AddBootstrapJs<IBsAlertJsFunctions, BsAlertJsFunctions>()
            .AddBootstrapJs<IBsButtonJsFunctions, BsButtonJsFunctions>()
            .AddBootstrapJs<IBsCarouselJsFunctions, BsCarouselJsFunctions>()
            .AddBootstrapJs<IBsCheckboxJsFunctions, BsCheckboxJsFunctions>()
            .AddBootstrapJs<IBsCollapseJsFunctions, BsCollapseJsFunctions>()
            .AddBootstrapJs<IBsModalJsFunctions, BsModalJsFunctions>();
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
