namespace CSM_Foundation_Core.Core.Utils;

/// <summary>
///     Provide randomization utility methods.
/// </summary>
public static class RandomUtils {
    private static readonly Random Randomizer = new();

    /// <summary>
    ///     Gets a randomized string.
    /// </summary>
    /// <param name="size">
    ///     String size
    /// </param>
    /// <returns>
    ///     A randomized string.
    /// </returns>
    public static string String(int size) {
        char[] letters = new char[size];
        for (int i = 0; i < size; i++) {
            int code = Randomizer.Next(65, 91);
            letters[i] = (char)code;
        }

        return new string(letters);
    }
}
