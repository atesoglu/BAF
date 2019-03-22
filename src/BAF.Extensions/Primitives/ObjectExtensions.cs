using System;
using System.Globalization;

namespace BAF.Extensions.Primitives
{
    public static class ObjectExtensions
    {
        public static T To<T>(this object value) where T : struct
        {
            try { return (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture); } catch (Exception) { throw new Exception("Conversation is not supported."); }
        }
    }
}