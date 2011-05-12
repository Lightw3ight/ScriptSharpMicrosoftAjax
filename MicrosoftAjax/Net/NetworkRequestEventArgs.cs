// NetworkRequestEventArgs.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sys.Net
{
	/// <summary>
	/// http://msdn.microsoft.com/en-us/library/bb397488.aspx
	/// </summary>
	[Imported]
	public class NetworkRequestEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the Web request to be routed to the current <see cref="Sys.Net.WebRequestExecutor"/> instance.
		/// </summary>
		/// <remarks>
		/// Use this property to inspect the contents of a Web request before it is routed to the current instance of the Sys.Net.WebRequestExecutor class.
		/// You can access the Web request instance from the handler that is called before the request is routed.
		/// This event handler is added by using the add_invokingRequest method.
		/// </remarks>
		public WebRequestExecutor WebRequest
		{
			get { return null; }
		}
	}
}
