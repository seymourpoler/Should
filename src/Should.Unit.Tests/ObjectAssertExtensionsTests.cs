using NUnit.Framework;
using Should.Core.Exceptions;

namespace Should.Unit.Tests
{
    [TestFixture]
    public class ObjectAssertExtensionsTests
    {
        [Test]
        public void ShouldBeType()
        {
            "Hello everyone".ShouldBeType<string>();
        }

        [Test]
        [ExpectedException(typeof(IsTypeException))]
        public void ThrowsTypeExceptionIfDoesNotShouldBeType()
        {
            "Hello everyone".ShouldBeType<int>();
        }

        [Test]
        public void ShouldNotBeTypeOf()
        {
            "Hello everyone".ShouldNotBeType<int>();
        }

        [Test]
        [ExpectedException(typeof(IsNotTypeException))]
        public void ThrowsIsNotTypeExceptionWhenShouldNotBeType()
        {
            "Hello everyone".ShouldNotBeType<string>();
        }

        [Test]
        public void ShouldBeNull()
        {
			var value = (string)null;
            value.ShouldBeNull();
        }

		[Test]
		[ExpectedException(typeof(NullException))]
		public void ThrowsNullExceptionWhenShouldBeNull()
		{
			var value = "Hello";
			value.ShouldBeNull();
		}

		[Test]
		public void ShouldNotBeNull()
		{
			var value = "hello";
			value.ShouldNotBeNull();
		}

		[Test]
		[ExpectedException(typeof(NotNullException))]
		public void ThrowsNotNullExceptionWhenShouldNotBeNull()
		{
			var value = (string)null;
			value.ShouldNotBeNull();
		}
    }
}
