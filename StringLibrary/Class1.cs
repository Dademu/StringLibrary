﻿namespace UtilityLibraries;

/// <summary>
///this class holds the extension method for the string data type
/// </summary>
public static class StringLibrary
{
    /// <summary>
    /// this method checks if the string starts with an upper case letter
    /// </summary>
    /// <param name="str"></param>
    /// <returns> True or false meaning the first letter is uppercase or not</returns>
    /// <example>
    /// Use this method to check if the first letter of a string is uppercase
    /// <code>
    /// var x = "Hello".StartsWithUpper()
    /// 
    /// ;
    /// </code>
    /// </example>
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}
