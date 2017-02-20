using System;
using Should.Core.Assertions;
using Should.Core.Exceptions;

namespace Should
{
	public static partial class StringAssertionExtensions
	{
		/// <summary>
		/// Verifies that a string contains a given sub-string, using the current culture.
		/// </summary>
		/// <param name="actualString">The string to be inspected</param>
		/// <param name="expectedSubString">The sub-string expected to be in the string</param>
		/// <exception cref="ContainsException">Thrown when the sub-string is not present inside the string</exception>
		public static int ShouldContain(this string actualString,
			string expectedSubString)
		{
			return Assert.Contains(expectedSubString, actualString);
		}

		/// <summary>
		/// Verifies that a string contains a given sub-string, using the given comparison type.
		/// </summary>
		/// <param name="actualString">The string to be inspected</param>
		/// <param name="expectedSubString">The sub-string expected to be in the string</param>
		/// <param name="comparisonType">The type of string comparison to perform</param>
		/// <exception cref="ContainsException">Thrown when the sub-string is not present inside the string</exception>
		public static void ShouldContain(this string actualString,
			string expectedSubString,
			StringComparison comparisonType)
		{
			Assert.Contains(expectedSubString, actualString, comparisonType);
		}
	}
}

