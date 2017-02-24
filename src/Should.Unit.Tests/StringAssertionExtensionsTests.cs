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
		public void ReturnsPositionIfContains()
		{
			var message = "the text";

			var result = message.ShouldContain ("text");

			Assert.That(result, Is.GreaterThanOrEqualTo(1));
		}

		[Test]
		[ExpectedException(typeof(ContainsException))]
		public void ThrowsExceptionWhenNotContains()
		{
			var message = "the text";

			message.ShouldContain ("one, two");

			throw new AssertionException ("Assertion fails");
		}

		[Test]
		public void ShouldNotContains()
		{
			var message = "the text";

			message.ShouldNotContain ("aqswdefr");

			Assert.IsTrue(true);
		}

		[Test]
		[ExpectedException(typeof(DoesNotContainException))]
		public void ThrowsExceptionWhenContains()
		{
			var message = "the text";

			message.ShouldNotContain ("the ");

			throw new AssertionException ("Assertion fails");
		}

		[Test]
		public void ShouldNotContain()
		{
			var message = "the text";

			message.ShouldNotContain ("aqswdefr");

			Assert.IsTrue(true);
		}

		[Test]
		public void ShouldStartWith()
		{
			var message = "the text";

			message.ShouldStartWith ("the ");

			Assert.IsTrue(true);
		}

		[Test]
		[ExpectedException(typeof(StartsWithException))]
		public void ThrowsExceptionWhenDoesNotStartsWith()
		{
			var message = "the text";

			message.ShouldStartWith ("one, ");

			throw new AssertionException ("Assertion fails");
		}
	}
}

