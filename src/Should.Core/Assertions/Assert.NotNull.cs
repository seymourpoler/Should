using System;
using Should.Core.Exceptions;

namespace Should.Core.Assertions
{
	public partial class Assert
	{
		/// <summary>
		/// Verifies that an object reference is not null.
		/// </summary>
		/// <param name="object">The object to be validated</param>
		/// <exception cref="NotNullException">Thrown when the object is not null</exception>
		public static void NotNull(object @object)
		{
			if (@object == null)
				throw new NotNullException();
		}

		/// <summary>
		/// Verifies that an object reference is not null.
		/// </summary>
		/// <param name="object">The object to be validated</param>
		/// <exception cref="NotNullException">Thrown when the object is not null</exception>
		public static void NotNull(object @object, string message)
		{
			if (@object == null)
				throw new NotNullException(message);
		}
	}
}

