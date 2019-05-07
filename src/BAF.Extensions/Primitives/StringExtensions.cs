using BAF.Extensions.Collection;
using System;

namespace BAF.Extensions.Primitives
{
    public static class StringExtensions
    {
        /// <summary>
        /// Return the string with the leftmost number_of_characters characters removed.
        /// </summary>
        /// <param name="str">The string being extended</param>
        /// <param name="numberOfCharacters">The number of characters to remove.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string RemoveLeft(this string str, int numberOfCharacters)
        {
            return str.Length <= numberOfCharacters ? "" : str.Substring(numberOfCharacters);
        }
        /// <summary>
        /// Removes first occurrence of the given prefixes from beginning of the given string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="prefixes">one or more prefix.</param>
        /// <returns>Modified string or the same string if it has not any of given prefixes</returns>
        public static string RemovePrefix(this string str, params string[] prefixes)
        {
            if (str.IsNullOrEmpty())
            {
                return null;
            }

            if (prefixes.IsNullOrEmpty())
            {
                return str;
            }

            foreach (var preFix in prefixes)
            {
                if (str.StartsWith(preFix))
                {
                    return str.Right(str.Length - preFix.Length);
                }
            }

            return str;
        }

        /// <summary>
        /// Returns the Right part of the string.
        /// </summary>
        /// <param name="value">The original string.</param>
        /// <param name="characterCount">The character count to be returned.</param>
        /// <returns>The right part</returns>
        public static string Right(this string value, int characterCount)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            if (characterCount >= value.Length)
                throw new ArgumentOutOfRangeException(nameof(characterCount), characterCount, "characterCount must be less than length of string");
            return value.Substring(value.Length - characterCount);
        }

        /// <summary>
        /// Indicates whether this string is null or an System.String.Empty string.
        /// </summary>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}