// WebRequestManager.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sys.Net
{
	/// <summary>
	/// Manages the flow of the Web requests issued by the <see cref="Sys.Net.WebRequest"/> object to the associated executor object.
	/// http://msdn.microsoft.com/en-us/library/bb397435.aspx
	/// </summary>
	[Imported]
	public static class WebRequestManager
	{
		/// <summary>
		/// Gets or sets the time-out for the default network executor.
		/// </summary>
		/// <remarks>
		/// Use the defaultTimeout property to get or set the time in milliseconds that the default executor should wait before timing out a Web request.
		/// By setting a time-out value that is not zero, you can make sure that a pending Web request returns the control back to the caller in a timely manner.
		/// </remarks>
		public static int DefaultTimeout
		{
			get { return 0; }
			set { }
		}

		/// <summary>
		/// Occurs when a handler function is called for the request.
		/// </summary>
		public static event EventHandler<NetworkRequestEventArgs> InvokingRequest;

		/// <summary>
		/// Occurs when a request has been handled.
		/// </summary>
		public static event EventHandler CompletedRequest;

		/// <summary>
		/// Sends Web requests to the default network executor.
		/// </summary>
		/// <param name="request">An instance of the <see cref="Sys.Net.WebRequest"/> class.</param>
		/// <remarks>
		/// The executeRequest method sends Web requests to the default executor. To execute a Web request, you must call the invoke method.
		/// </remarks>
		public static void ExecuteRequest(WebRequest request)
		{
		}
	}
}
