using System;
using NUnit.Framework;

namespace Should.Unit.Tests
{
	[TestFixture]
	public class ActionAssertionExtensionsTests
	{
		[Test]
		public void ShouldThrows()
        {
			Action action = () => {
				throw new TestException ();
			};

            action.ShouldThrow<TestException>();
        }
	}

    public class TestException : Exception { }
}

