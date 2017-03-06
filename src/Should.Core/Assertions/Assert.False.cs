using Should.Core.Exceptions;


namespace Should.Core.Assertions
{
	public partial class Assert
	{
		/// <summary>
		/// Verifies that the condition is false.
		/// </summary>
		/// <param name="condition">The condition to be tested</param>
		/// <param name="userMessage">The message to show when the condition is not false</param>
		/// <exception cref="FalseException">Thrown if the condition is not false</exception>
		public static void False(bool condition, string userMessage)
		{
			if (condition)
				throw new FalseException(userMessage);
		}
	}
}

