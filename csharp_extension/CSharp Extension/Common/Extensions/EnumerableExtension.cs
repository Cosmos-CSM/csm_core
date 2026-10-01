namespace CSM_Foundation_Core.Core.Extensions;


/// <summary>
///     Extends <see cref="IEnumerable{T}"/> class.
/// </summary>
public static class EnumerableExtension {

    /// <summary>
    ///     Checks if the <paramref name="obj"/> is empty.
    /// </summary>
    /// <typeparam name="T">
    ///     Type of the <see cref="IEnumerable{T}"/> content.
    /// </typeparam>
    /// <param name="obj">
    ///     Current object.
    /// </param>
    /// <returns>
    ///     Whether the collection is empty or not.
    /// </returns>
    public static bool Empty<T>(this IEnumerable<T> obj) {
        return !obj.Any();
    }
}
