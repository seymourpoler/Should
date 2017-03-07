using NUnit.Framework;

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
    }
}
