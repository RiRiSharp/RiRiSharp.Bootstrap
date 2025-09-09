using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RiRiSharp.Bootstrap.BaseComponents;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RiRiSharp.Bootstrap.UnitTests;

public abstract class BsInputBaseComponentTests<TComponent, TValue>([StringSyntax("Html")] string htmlFormat) : BsComponentTests<TComponent>(htmlFormat) where TComponent : InputBase<TValue>, IBsComponent
{
    protected TValue _value;
    protected override void BindParameters(ComponentParameterCollectionBuilder<TComponent> parameterBuilder)
    {
        parameterBuilder.Bind(p => p.Value, _value, newValue => _value = newValue);
    }
}