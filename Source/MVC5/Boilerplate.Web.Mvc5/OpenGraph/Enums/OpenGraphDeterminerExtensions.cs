﻿namespace Boilerplate.Web.Mvc.OpenGraph
{
    /// <summary>
    /// <see cref="OpenGraphDeterminer"/> extension methods.
    /// </summary>
    internal static class OpenGraphDeterminerExtensions
    {
        /// <summary>
        /// Returns the lowercase <see cref="string"/> representation of the <see cref="OpenGraphDeterminer"/>.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The lowercase <see cref="string"/> representation of the <see cref="OpenGraphDeterminer"/>.</returns>
        public static string ToLowercaseString(this OpenGraphDeterminer determiner)
        {
            switch (determiner)
            {
                case OpenGraphDeterminer.A:
                    return "a";
                case OpenGraphDeterminer.An:
                    return "an";
                case OpenGraphDeterminer.Auto:
                    return "auto";
                case OpenGraphDeterminer.The:
                    return "the";
                case OpenGraphDeterminer.Blank:
                default:
                    return string.Empty;
            }
        }
    }
}