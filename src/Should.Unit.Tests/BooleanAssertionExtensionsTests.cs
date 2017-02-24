using NUnit.Framework;
using Should.Core.Exceptions;

namespace Should.Unit.Tests
{
	[TestFixture]
	public class BooleanAssertionExtensionsTests
	{
		[Test]
		public void ShouldBeFalse(){
			false.ShouldBeFalse ();
		}

		[Test]
		[ExpectedException(typeof(FalseException))]
		public void ThrowsFalseException()
		{
			true.ShouldBeFalse ();
		}

		[Test]
		public void ThrowsFalseExceptionWithMessage()
		{
			var message = "simple message";
			true.ShouldBeFalse (message);
		}
	}
}

