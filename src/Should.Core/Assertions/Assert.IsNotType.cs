
using System;
using Should.Core.Exceptions;

namespace Should.Core.Assertions
{
    public partial class Assert
    {
        /// <summary>        
        /// Verifies that an object is not exactly the given type.
        /// </summary>
        /// <typeparam name="T">The type the object should not be</typeparam>
        /// <param name="object">The object to be evaluated</param>
        /// <exception cref="IsNotTypeException">Thrown when the object is the given type</exception>
        public static void IsNotType<T>(object @object)
        {
            IsNotType(typeof(T), @object);
        }

        /// <summary>
        /// Verifies that an object is not exactly the given type.
        /// </summary>
        /// <param name="expectedType">The type the object should not be</param>
        /// <param name="object">The object to be evaluated</param>
        /// <exception cref="IsNotTypeException">Thrown when the object is the given type</exception>
        public static void IsNotType(Type expectedType,
                                     object @object)
        {
            if (expectedType.Equals(@object.GetType()))
                throw new IsNotTypeException(expectedType, @object);
        }
    }
}
