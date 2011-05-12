using System;
using System.Collections.Generic;

namespace Sys
{
	/// <summary>
	/// Indicates that the type that implements the interface provides disposing notifications.
	/// http://msdn.microsoft.com/en-us/library/bb310819.aspx
	/// </summary>
	public interface INotifyDisposing
	{
		/// <summary>
		/// Occurs when an object's resources are released.
		/// </summary>
		event EventHandler Disposing;
	}
}
