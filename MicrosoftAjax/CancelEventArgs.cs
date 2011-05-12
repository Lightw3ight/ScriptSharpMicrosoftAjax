using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys
{
	/// <summary>
	/// Provides the base class for events that can be canceled.
	/// http://msdn.microsoft.com/en-us/library/bb311009.aspx
	/// </summary>
	/// <remarks>
	/// Event handlers can use the cancel property to cancel the operation in progress. The semantics of canceling an event depend on the event source.
	/// </remarks>
	[Imported]
	public abstract class CancelEventArgs : EventArgs
	{
		/// <summary>
		/// Gets or sets a value that specifies whether the event source should cancel the operation that caused the event.
		/// </summary>
		public bool Cancel
		{
			get { return false; }
			set { }
		}
	}
}
