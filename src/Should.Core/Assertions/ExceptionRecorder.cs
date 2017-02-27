using System;

namespace Should.Core.Assertions
{
    /// <summary>
    /// Allows the user to record actions for a test.
    /// </summary>
    public static class ExceptionRecorder
    {
        /// <summary>
        /// Records any exception which is thrown by the given code.
        /// </summary>
        /// <param name="code">The code which may thrown an exception.</param>
        /// <returns>Returns the exception that was thrown by the code; null, otherwise.</returns>
        public static Exception Record(Assert.ThrowsDelegate code)
        {
            try
            {
                code();
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        /// <summary>
        /// Records any exception which is thrown by the given code that has
        /// a return value. Generally used for testing property accessors.
        /// </summary>
        /// <param name="code">The code which may thrown an exception.</param>
        /// <returns>Returns the exception that was thrown by the code; null, otherwise.</returns>
        public static Exception Record(Assert.ThrowsDelegateWithReturn code)
        {
            try
            {
                code();
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

		public static Exception Record(Action action)
		{
			try
			{
				action();
				return null;
			}
			catch (Exception ex)
			{
				return ex;
			}
		}
        
    }
}