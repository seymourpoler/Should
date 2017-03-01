using Should.Core.Assertions;

namespace Should
{
    public static partial class ObjectAssertExtensions
    {
        /// <summary>
        /// Verifies that an object is not exactly the given type.
        /// </summary>
        /// <typeparam name="T">The type the object should not be</typeparam>
        /// <param name="object">The object to be evaluated</param>
        /// <exception cref="IsTypeException">Thrown when the object is the given type</exception>
        public static void ShouldNotBeType<T>(this object @object)
        {
            Assert.IsNotType<T>(@object);
        }
    }
}
