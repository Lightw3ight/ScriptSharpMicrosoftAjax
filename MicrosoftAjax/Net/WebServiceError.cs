using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Sys.Net
{
	/// <summary>
	/// The WebServiceError is the type of the object that is returned to the failed callback function.
	/// http://msdn.microsoft.com/en-us/library/bb397475.aspx
	/// </summary>
	[Imported]
	public class WebServiceError
	{
		/// <summary>
		/// Gets the error exception type.
		/// </summary>
		public string ExceptionType
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the error message returned by the error.
		/// </summary>
		public string Message
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the stack trace that is returned by the server.
		/// </summary>
		public string StackTrace
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the status code for the HTTP response.
		/// </summary>
		public int StatusCode
		{
			get { return 0; }
		}

		/// <summary>
		/// Gets a value that indicates whether the Web service failed because it timed out.
		/// </summary>
		public bool TimedOut
		{
			get { return false; }
		}

		/// <summary>
		/// Gets the raw error information.
		/// </summary>
		public object ErrorObject
		{
			get { return null; }
		}
	}
}
