﻿using System;
using NUnit.Framework;
using Should.Core.Exceptions;

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

		[Test]
		[ExpectedException(typeof(ThrowsException))]
		public void ThrowsExceptionWhenShouldThrowsFails()
		{
			Action action = () => {};

			action.ShouldThrow<TestException>();
		}
	}

    public class TestException : Exception { }
}

