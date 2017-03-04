using System;
using Should.Core.Assertions;

namespace Should
{
	/// <summary>
	/// Verifies that an object reference is not null.
	/// </summary>
	/// <param name="object">The object to be validated</param>
	/// <exception cref="NotNullException">Thrown when the object is not null</exception>
	public static partial class ObjectAssertExtensions
	{
		public static void ShouldNotBeNull<T>(this T @object) where T : class
		{
			Assert.NotNull(@object);
		}
	}
}

