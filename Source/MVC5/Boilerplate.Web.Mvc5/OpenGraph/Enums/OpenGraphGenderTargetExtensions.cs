﻿namespace Boilerplate.Web.Mvc.OpenGraph
{
    /// <summary>
    /// <see cref="OpenGraphGender"/> extension methods.
    /// </summary>
    internal static class OpenGraphTargetGenderExtensions
    {
        /// <summary>
        /// Returns the lowercase <see cref="string"/> representation of the <see cref="OpenGraphTargetGender"/>.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The lowercase <see cref="string"/> representation of the <see cref="OpenGraphTargetGender"/>.</returns>
        public static string ToLowercaseString(this OpenGraphTargetGender gender)
        {
            switch (gender)
            {
                case OpenGraphTargetGender.Male:
                    return "male";
                case OpenGraphTargetGender.Female:
                    return "female";
                case OpenGraphTargetGender.Unisex:
                    return "unisex";
                default:
                    return string.Empty;
            }
        }
    }
}