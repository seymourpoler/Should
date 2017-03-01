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

    }
}
