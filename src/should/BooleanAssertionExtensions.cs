using Should.Core.Assertions;

namespace Should
{
    /// <summary>
    /// Extensions which provide assertions to classes derived from <see cref="Boolean"/>.
    /// </summary>
	public static partial class BooleanAssertionExtensions
    {

        /// <summary>
        /// Verifies that an expression is true.
        /// </summary>
        /// <param name="condition">The condition to be inspected</param>
        /// <exception cref="TrueException">Thrown when the condition is false</exception>
        public static void ShouldBeTrue(this bool condition)
        {
            Assert.True(condition);
        }

        /// <summary>
        /// Verifies that an expression is true.
        /// </summary>
        /// <param name="condition">The condition to be inspected</param>
        /// <param name="userMessage">The message to be shown when the condition is false</param>
        /// <exception cref="TrueException">Thrown when the condition is false</exception>
        public static void ShouldBeTrue(this bool condition,
                                        string userMessage)
        {
            Assert.True(condition, userMessage);
        }
    }
}