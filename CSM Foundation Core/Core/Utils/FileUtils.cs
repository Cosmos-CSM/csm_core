using System.Text.Json;

namespace CSM_Foundation_Core.Core.Utils;


/// <summary>
///     Provide system files utility methods.
/// </summary>
public class FileUtils {

    /// <summary>
    ///     Formats the given <paramref name="path"/> for system sensitive '/' or '\\' usage.
    /// </summary>
    /// <param name="path">
    ///     System file path.
    /// </param>
    /// <returns>
    ///     Formatted system file path.
    /// </returns>
    public static string FormatPath(string path) {
        string wd = Directory.GetCurrentDirectory();
        if (wd.Contains('/')) {
            path = path.Replace("\\", "/");
        }

        return path;
    }

    /// <summary>
    ///     Gets the given <paramref name="path"/> file content as an <typeparamref name="TModel"/> instance.
    /// </summary>
    /// <typeparam name="TModel">
    ///     Type of the converted data model.
    /// </typeparam>
    /// <param name="path">
    ///     File system path.
    /// </param>
    /// <returns>
    ///     Converted file content into a <typeparamref name="TModel"/> instance.
    /// </returns>
    /// <exception cref="FileNotFoundException">
    ///     Thrown when the given <paramref name="path"/> does not exist.
    /// </exception>
    public static TModel Deserealize<TModel>(string path) {
        if (!File.Exists(path)) {
            throw new FileNotFoundException(path);
        }

        Stream fs = File.OpenRead(path);
        TModel m = JsonSerializer.Deserialize<TModel>(fs)!;
        return m;
    }
}
