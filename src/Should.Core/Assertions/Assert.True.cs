using Should.Core.Exceptions;

namespace Should.Core.Assertions
{
	public partial class Assert
	{
		/// <summary>
        /// Verifies that an expression is true.
        /// </summary>
        /// <param name="condition">The condition to be inspected</param>
        /// <exception cref="TrueException">Thrown when the condition is false</exception>
        public static void True(bool condition)
        {
            True(condition, null);
        }

        /// <summary>
        /// Verifies that an expression is true.
        /// </summary>
        /// <param name="condition">The condition to be inspected</param>
        /// <param name="userMessage">The message to be shown when the condition is false</param>
        /// <exception cref="TrueException">Thrown when the condition is false</exception>
        public static void True(bool condition, string userMessage)
        {
            if (!condition)
                throw new TrueException(userMessage);
        }
	}
}

