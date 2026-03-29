namespace CSM_Foundation_Core.Core.Extensions;


/// <summary>
///     Extends <see cref="DateTime"/> class.
/// </summary>
public static class DateTimeExtensions {

    /// <summary>
    ///     Trims the given <paramref name="obj"/> to seconds.
    /// </summary>
    /// <param name="obj">
    ///     Current object.
    /// </param>
    /// <returns>
    ///     Trimmed <see cref="DateTime"/> to seconds.
    /// </returns>
    public static DateTime Trim(this DateTime obj) {
        return new DateTime(obj.Year, obj.Month, obj.Day, obj.Hour, obj.Minute, obj.Second);
    }

}
