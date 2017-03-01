using System;
using Should.Core.Exceptions;

namespace Should.Core.Assertions
{
	public partial class Assert
	{
		/// <summary>
		/// Verifies that an object is exactly the given type (and not a derived type).
		/// </summary>
		/// <typeparam name="T">The type the object should be</typeparam>
		/// <param name="object">The object to be evaluated</param>
		/// <returns>The object, casted to type T when successful</returns>
		/// <exception cref="IsTypeException">Thrown when the object is not the given type</exception>
		public static void IsType<T>(object @object)
		{
			IsType(typeof(T), @object);
		}

		/// <summary>
		/// Verifies that an object is exactly the given type (and not a derived type).
		/// </summary>
		/// <param name="expectedType">The type the object should be</param>
		/// <param name="object">The object to be evaluated</param>
		/// <exception cref="IsTypeException">Thrown when the object is not the given type</exception>
		public static void IsType(Type expectedType, object @object)
		{
			if (@object == null || !expectedType.Equals(@object.GetType()))
				throw new IsTypeException(expectedType, @object);
		}
	}
}

