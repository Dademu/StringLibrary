namespace UtilityLibraries;

/// <summary>
///this class holds the extension method for the string data type
/// </summary>
public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}
