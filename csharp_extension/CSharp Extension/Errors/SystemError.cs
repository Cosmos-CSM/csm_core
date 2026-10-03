using CSharp_Extension.Errors.Abstractions.Bases;
using CSharp_Extension.Errors.Models;

namespace CSharp_Extension.Errors;


/// <summary>
///     Represents exception triggering events for <see cref="SystemError"/>.
/// </summary>
public enum SystemErrorEvents {

    /// <summary>
    ///     The inner framework related validations triggered an exception.
    /// </summary>
    FRAMEWORK,
}

/// <summary>
///     Represents a CSM native framework exception in order to provide solutions from a basic exception management system integrated.
/// </summary>
public class SystemError
    : ErrorBase<SystemErrorEvents> {

    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    /// <param name="message">
    ///     Exception description message.
    /// </param>
    /// <param name="frameworkException">
    ///     Framework native exception caught.
    /// </param>
    /// <param name="feedback">
    ///     User feedback data.
    /// </param>
    /// <param name="data">
    ///     Internal debugging exception data.
    /// </param>
    public SystemError(string message, Exception? frameworkException = null, ErrorFeedback[]? feedback = null, IDictionary<string, object?>? data = null)
        : base(message, SystemErrorEvents.FRAMEWORK, frameworkException, feedback ?? [], data ?? new Dictionary<string, object?>()) {
    }
}
