// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     An Assembly extension method that gets an attribute.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The attribute.</returns>
    public static T GetAttribute<T>(this Assembly @this) where T : Attribute
    {
        object[] configAttributes = Attribute.GetCustomAttributes(@this, typeof (T), false);

        if (configAttributes != null && configAttributes.Length > 0)
        {
            return (T) configAttributes[0];
        }

        return null;
    }
}