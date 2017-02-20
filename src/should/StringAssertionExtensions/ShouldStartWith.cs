using System;
using Should.Core.Assertions;
using Should.Core.Exceptions;

namespace Should
{
	public static partial class StringAssertionExtensions
	{
		public static void ShouldStartWith(this string actualString,
			string expectedStartString)
		{
			Assert.StartsWith(expectedStartString, actualString);
		}
	}
}

