using System;
using NUnit.Framework;
using Should;
using Should.Core.Exceptions;

namespace Should.Unit.Tests
{
	[TestFixture]
	public class StringAssertionExtensionsTests
	{
		[Test]
		public void ReturnsTrueIfContains()
		{
			var message = "the text";

			var result = message.ShouldContain ("text");

			Assert.That(result, Is.GreaterThanOrEqualTo(1));
		}

		[Test]
		[ExpectedException(typeof(ContainsException))]
		public void ThrowsIfNotContains()
		{
			var message = "the text";

			message.ShouldContain ("one, two");

			throw new AssertionException ("Assertion fails");
		}

		[Test]
		public void ReturnsTrueIfStartsWith()
		{
			var message = "the text";

			message.ShouldStartWith ("the ");

			Assert.IsTrue(true);
		}

		[Test]
		[ExpectedException(typeof(StartsWithException))]
		public void ThrowsIfNotStartsWith()
		{
			var message = "the text";

			message.ShouldStartWith ("one, ");

			throw new AssertionException ("Assertion fails");
		}
	}
}

