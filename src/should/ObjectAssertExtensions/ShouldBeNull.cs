using Should.Core.Assertions;

namespace Should
{
    public static partial class ObjectAssertExtensions
    {
        /// <summary>
        /// Verifies that an object reference is null.
        /// </summary>
        /// <param name="object">The object to be inspected</param>
        /// <exception cref="NullException">Thrown when the object reference is not null</exception>
		public static void ShouldBeNull(this object @object)
        {
            Assert.Null(@object);
        }
    }
}
