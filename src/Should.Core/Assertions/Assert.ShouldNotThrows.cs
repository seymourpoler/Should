using System;
using Should.Core.Assertions;
using Should.Core.Exceptions;

namespace Should.Core.Assertions
{
	public partial class Assert
	{
		public static void NotThrows<T>(Action action) where T : Exception
		{
			NotThrows(typeof(T), action);
		}

		private static void NotThrows(Type exceptionType, Action action){
			if(exceptionType == null){
				throw new ArgumentNullException ();
			}
			if(action == null){
				throw new ArgumentNullException ();
			}

			var exception = ExceptionRecorder.Record (action);
			if (exception != null)
				throw new DoesNotThrowException(exception);
		}
	}
}

