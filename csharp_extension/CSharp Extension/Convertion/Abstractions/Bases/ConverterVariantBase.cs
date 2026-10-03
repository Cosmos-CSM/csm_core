using CSharp_Extension.Convertion.Abstractions.Interfaces;

namespace CSharp_Extension.Convertion.Abstractions.Bases;

/// <inheritdoc cref="IConverterVariant"/>
public abstract class ConverterVariantBase
    : IConverterVariant {

    /// <inheritdoc/>
    public string Discriminator { get; init; }

    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    public ConverterVariantBase() {
        Discriminator = $"{GetType().GUID}";
    }
}
