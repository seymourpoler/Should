using NUnit.Framework;
using Should.Core.Exceptions;

namespace Should.Unit.Tests
{
    [TestFixture]
    public class ObjectAssertExtensionsTests
    {
        [Test]
        public void ShouldBeTypeOf()
        {
            "Hello everyone".ShouldBeType<string>();
        }

        [Test]
        [ExpectedException(typeof(IsTypeException))]
        public void ThrowsTypeExceptionIfDoesNotShouldBeTypeOf()
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
			object value;
            value.ShouldBeNull();
        }

		[Test]
		public void ShouldNotBeNull()
		{
			var value = new string("hello");
			value.ShouldNotBeNull();
		}
    }
}
