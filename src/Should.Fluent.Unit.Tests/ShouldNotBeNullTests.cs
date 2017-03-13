using NUnit.Framework;

namespace Should.Fluent.Unit.Tests
{
    [TestFixture]
    public class ShouldNotBeNullTests
    {
        [Test]
        public void ShouldNotBeNull()
        {
            "pepe".Should().Not.Be.Null();
        }
    }
}
