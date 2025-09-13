namespace RiRiSharp.Bootstrap.Internals.Exceptions;

public class CascadingParameterNotProvidedException : Exception
{
    public CascadingParameterNotProvidedException()
        : base("Cascading parameter was not provided.") { }

    public CascadingParameterNotProvidedException(string message)
        : base(message) { }

    public CascadingParameterNotProvidedException(string message, Exception innerException)
        : base(message, innerException) { }

    public CascadingParameterNotProvidedException(Type parameterType)
        : base($"Cascading parameter of type {parameterType.AssemblyQualifiedName} was not provided.")
    {
        ArgumentNullException.ThrowIfNull(parameterType);
    }
}
