using System.Reflection;

namespace CSM_Foundation_Core.Core.Utils;


/// <summary>
///     Provides utlity methods for objects handling.
/// </summary>
public static class ObjectUtils {

    /// <summary>
    ///     Clones the current object into a new instance with the same property values.
    /// </summary>
    /// <param name="obj">
    ///     Object reference to be cloned.
    /// </param>
    /// <returns>
    ///     Cloned <typeparamref name="TObject"/> instance.
    /// </returns>
    public static TObject Clone<TObject>(TObject obj) {
        if(obj is null) 
            return obj;

        Type objType = typeof(TObject);

        TObject? Cloned = (TObject?)Activator.CreateInstance(objType)
            ?? throw new Exception("PENDING WRONG ACTIVATION");
        PropertyInfo[] ObjectPropertiesInfo = objType.GetProperties();
        foreach (PropertyInfo PropertyInfo in ObjectPropertiesInfo) {
            object? OriginalValue = PropertyInfo.GetValue(obj);
            PropertyInfo.SetValue(Cloned, OriginalValue);
        }

        return Cloned.GetHashCode() == obj?.GetHashCode() ? throw new Exception("Same hash detected along clonation, fatal error.") : Cloned;
    }
}
