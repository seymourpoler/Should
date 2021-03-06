﻿using System;
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

        /// <summary>
        /// Verifies that a block of code does not throw any exceptions.
        /// </summary>
        /// <param name="testCode">A delegate to the code to be tested</param>
        public static void DoesNotThrow(ThrowsDelegate testCode)
        {
            Exception ex = ExceptionRecorder.Record(testCode);

            if (ex != null)
                throw new DoesNotThrowException(ex);
        }
    }
}

