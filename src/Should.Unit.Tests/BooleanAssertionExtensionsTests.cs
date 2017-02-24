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
                Assert.Fail("should be false with message");
            }
            catch (FalseException ex)
            {
                ex.Message.ShouldEqual(message);
            }
        }

	    [Test]
	    public void ShouldBeTrue()
	    {
	        true.ShouldBeTrue();
	    }

        [Test]
        [ExpectedException(typeof(TrueException))]
        public void ThrowsTrueException()
        {
            false.ShouldBeTrue();
        }

        [Test]
        public void TrueExceptionWithMessage()
        {
            var message = "message";
            try
            {
                false.ShouldBeTrue(message);
                Assert.Fail("should be true with message");
            }
            catch (TrueException ex)
            {
                ex.Message.ShouldEqual(message);
            }
        }
    }
}

