using NUnit.Framework;
using Should.CollectionAssertionExtensions;
using Should.Core.Exceptions;

namespace Should.Unit.Tests
{
    [TestFixture]
    public class CollectionAssertionExtensionsTests
    {
        [Test]
        public void ShouldBeEmpty()
        {
            var list = new int[] {};

            list.ShouldBeEmpty();
        }

        [Test]
        [ExpectedException(typeof (EmptyException))]
        public void ThrowsEmptyExceptionWhenCollectionIsNotEmpty()
        {
            var list = new int[] {1, 2, 3, 34};

            list.ShouldBeEmpty();
        }
    }
}
