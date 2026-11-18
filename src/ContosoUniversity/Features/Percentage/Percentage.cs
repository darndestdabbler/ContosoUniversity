namespace ContosoUniversity.Features.Percentage
{
    using System;

    /// <summary>
    /// The arithmetic behind the percentage page.
    /// </summary>
    public static class Percentage
    {
        /// <summary>Works out what percentage one number is of another.</summary>
        /// <param name="part">The number taken as a part.</param>
        /// <param name="whole">The number taken as the whole.</param>
        /// <returns><paramref name="part"/> as a percentage of <paramref name="whole"/>, rounded to two places.</returns>
        /// <exception cref="ArgumentException"><paramref name="whole"/> is zero.</exception>
        public static decimal Of(decimal part, decimal whole)
        {
            if (whole == 0)
            {
                throw new ArgumentException("The whole must not be zero.", "whole");
            }

            return Math.Round(part / whole * 100, 2);
        }
    }
}
