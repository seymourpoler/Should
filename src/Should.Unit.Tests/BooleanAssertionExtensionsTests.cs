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
            var message = "message";
            try
            {
                true.ShouldBeFalse(message);
                Assert.Fail("swhould be false with message");
            }
            catch (FalseException ex)
            {
                ex.Message.ShouldEqual(message);
            }
        }
    }
}

