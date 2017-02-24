using Should.Core.Assertions;

namespace Should
{
	public static partial class BooleanAssertionExtensions
	{
		/// <summary>
		/// Verifies that the condition is false.
		/// </summary>
		/// <param name="condition">The condition to be tested</param>
		/// <exception cref="FalseException">Thrown if the condition is not false</exception>
		public static void ShouldBeFalse(this bool condition)
		{
			Assert.False(condition);
		}

		/// <summary>
		/// Verifies that the condition is false.
		/// </summary>
		/// <param name="condition">The condition to be tested</param>
		/// <param name="userMessage">The message to show when the condition is not false</param>
		/// <exception cref="FalseException">Thrown if the condition is not false</exception>
		public static void ShouldBeFalse(this bool condition,
			string userMessage)
		{
			Assert.False(condition, userMessage);
		}
	}
}

