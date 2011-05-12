using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys
{
	/// <summary>
	/// Used by the <see cref="Sys.Component.PropertyChanged"/> event to indicate which property has changed.
	/// http://msdn.microsoft.com/en-us/library/bb310957.aspx
	/// </summary>
	[Imported]
	public class PropertyChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the name of the property that changed.
		/// </summary>
		/// <remarks>
		/// Use the propertyName property to determine the name of the property that changed.
		/// </remarks>
		public string PropertyName
		{
			get { return null; }
		}
	}
}
