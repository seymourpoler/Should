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
		public void ThrowsIfContains()
		{
			var message = "the text";

			message.ShouldContain ("one, two");

			throw new AssertionException ("Assertion fails");
		}}
}

