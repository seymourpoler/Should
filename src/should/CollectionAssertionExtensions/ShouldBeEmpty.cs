using System;
using System.Collections;
using Should.Core.Assertions;
using Should.Core.Exceptions;

namespace Should.CollectionAssertionExtensions
{
    public static partial class CollectionAssertionExtensions
    {
        /// <summary>
        /// Verifies that a collection is empty.
        /// </summary>
        /// <param name="collection">The collection to be inspected</param>
        /// <exception cref="ArgumentNullException">Thrown when the collection is null</exception>
        /// <exception cref="EmptyException">Thrown when the collection is not empty</exception>
        public static void ShouldBeEmpty(this IEnumerable collection)
        {
            Assert.Empty(collection);
        }
    }
}
