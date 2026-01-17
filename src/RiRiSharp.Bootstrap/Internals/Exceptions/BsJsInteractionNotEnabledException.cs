using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace RiRiSharp.Bootstrap.Internals.Exceptions;

public class BsJsInteractionNotEnabledException : Exception
{
#pragma warning disable IDE0055
    public BsJsInteractionNotEnabledException()
        : base(
            $"JS interaction is not enabled. Call {nameof(BsStartupExtensions.EnableJsInteractiveComponents)} to enable this operation."
        ) { }
#pragma warning restore IDE0055

    internal BsJsInteractionNotEnabledException(string? message)
        : base(message) { }

    internal BsJsInteractionNotEnabledException(string? message, Exception? innerException)
        : base(message, innerException) { }

    internal static void ThrowIfNull(
        [NotNull] object? jsFunctionsReference,
        string operationName,
        [CallerArgumentExpression(nameof(jsFunctionsReference))] string? dependencyName = null
    )
    {
        if (jsFunctionsReference is not null)
        {
            return;
        }

        var msg =
            $"Cannot call {operationName} because '{dependencyName}' is null."
            + " Ensure JS injection/registration is enabled, "
            + $"for example by calling {nameof(BsStartupExtensions.EnableJsInteractiveComponents)} on startup.";
        throw new BsJsInteractionNotEnabledException(msg);
    }
}
