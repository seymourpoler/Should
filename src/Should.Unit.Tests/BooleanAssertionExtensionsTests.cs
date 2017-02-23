using NUnit.Framework;

namespace Should.Unit.Tests
{
	[TestFixture]
	public class BooleanAssertionExtensionsTests
	{
		[Test]
		public void ShouldBeFalse(){
			false.ShouldBeFalse ();
		}
	}
}

