using System;
using Should.Core.Exceptions;

namespace Should.Core.Assertions
{
	public partial class Assert
	{
		public static T Throws<T>(Action action) where T : Exception
		{
			return (T)Throws(typeof(T), action);
		}

		public static Exception Throws(Type exceptionType, Action action){
			if(exceptionType == null){
				throw new ArgumentNullException ();
			}
			if(action == null){
				throw new ArgumentNullException ();
			}

			var exception = ExceptionRecorder.Record (action);
			if (exception == null)
				throw new ThrowsException(exceptionType);

			if (!exceptionType.Equals(exception.GetType()))
				throw new ThrowsException(exceptionType, exception);

			return exception;
		}
	}
}

