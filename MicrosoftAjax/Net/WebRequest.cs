using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys.Net
{
	/// <summary>
	/// Provides client script functionality to make a Web request.
	/// http://msdn.microsoft.com/en-us/library/bb310979.aspx
	/// </summary>
	[Imported]
	public class WebRequest
	{
		/// <summary>
		/// Called when the web service has completed
		/// </summary>
		public event EventHandler Completed;

		/// <summary>
		/// Gets or sets the URL of the <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		public string Url
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets or sets the user context associated with the <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		public object UserContext
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets or sets the time-out value for the <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		public int Timeout
		{
			get { return 0; }
			set { }
		}

		/// <summary>
		/// Gets or sets the HTTP verb that was used by the <see cref="Sys.Net.WebRequest"/> class to issue the Web request.
		/// </summary>
		public string HttpVerb
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets the HTTP headers for the <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		public Dictionary<string,string> Headers
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets or sets the executor of the associated <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		public WebRequestExecutor Executor 
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets or sets the HTTP body of the <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		public string Body
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Executes a Web request.
		/// </summary>
		/// <remarks>
		/// If you have registered a completed request event handler for the Sys.Net.WebRequest instance,
		/// that handler is called asynchronously by the network stack as the request progresses.
		/// Calling invoke more than one time for the same WebRequest instance throws an exception
		/// if the executor has already issued the network request.
		/// </remarks>
		public void Invoke()
		{
		}

		/// <summary>
		/// Gets the resolved URL of the <see cref="Sys.Net.WebRequest"/> instance.
		/// </summary>
		/// <remarks>
		/// This method returns the absolute URL representation, of the URL associated with the WebRequest instance.
		/// The URL includes the protocol identifier and the fully qualified domain name.
		/// This method is used by other classes such as network executors to determine the target URL for a Web request.
		/// </remarks>
		/// <returns>The resolved URL that the Web request is directed to.</returns>
		public string GetResolvedUrl()
		{
			return null;
		}
	}
}
