﻿using System;
using Should.Core.Assertions;

namespace Should
{
	public static partial class StringAssertionExtensions
	{
		/// <summary>
		/// Verifies that a string does not contain a given sub-string, using the current culture.
		/// </summary>
		/// <param name="actualString">The string to be inspected</param>
		/// <param name="expectedSubString">The sub-string which is expected not to be in the string</param>
		/// <exception cref="DoesNotContainException">Thrown when the sub-string is present inside the string</exception>
		public static void ShouldNotContain(this string actualString,
			string expectedSubString)
		{
			Assert.DoesNotContain(expectedSubString, actualString);
		}

		/// <summary>
		/// Verifies that a string does not contain a given sub-string, using the current culture.
		/// </summary>
		/// <param name="actualString">The string to be inspected</param>
		/// <param name="expectedSubString">The sub-string which is expected not to be in the string</param>
		/// <param name="comparisonType">The type of string comparison to perform</param>
		/// <exception cref="DoesNotContainException">Thrown when the sub-string is present inside the given string</exception>
		public static void ShouldNotContain(this string actualString,
			string expectedSubString,
			StringComparison comparisonType)
		{
			Assert.DoesNotContain(expectedSubString, actualString, comparisonType);
		}
	}
}

