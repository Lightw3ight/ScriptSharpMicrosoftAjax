using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys.UI
{
	/// <summary>
	/// Provides a base class for all AJAX behaviors in ASP.NET.
	/// http://msdn.microsoft.com/en-us/library/bb311020.aspx
	/// </summary>
	/// <remarks>
	/// A behavior is a component that extends the functionality of the DOM element that it is associated with.
	/// The Behavior class should not be instantiated directly; it is a base class for other behaviors to derive from.
	/// </remarks>
	[Imported]
	public class Behavior : Component
	{
		/// <summary>
		/// Gets the HTML Document Object Model (DOM) element that the current <see cref="Sys.UI.Behavior"/> object is associated with.
		/// </summary>
		public DomElement Element
		{
			get { return null; }
		}

		/// <summary>
		/// Gets or sets the identifier for the <see cref="Sys.UI.Behavior"/> object.
		/// </summary>
		public string Id
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets or sets the name of the <see cref="Sys.UI.Behavior"/> object.
		/// </summary>
		public string Name
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets the <see cref="Sys.UI.Behavior"/> objects that are associated with the specified HTML Document Object Model (DOM) element. This member is static and can be invoked without creating an instance of the class.
		/// </summary>
		/// <param name="element">The <see cref="Sys.UI.DomElement"/> object to search.</param>
		/// <returns>An array of references to Behavior objects, or null if no references exist.</returns>
		public static Behavior[] GetBehaviors(DomElement element)
		{
			return null;
		}

		/// <summary>
		/// Gets a <see cref="Sys.UI.Behavior"/> instance with the specified name property from the specified HTML Document Object Model (DOM) element. This member a static member and can be invoked without creating an instance of the class.
		/// </summary>
		/// <param name="element">The <see cref="Sys.UI.DomElement"/> object to search.</param>
		/// <param name="name">The name property of the Behavior instance to look for.</param>
		/// <returns>The specified Behavior object, if found; otherwise, null.</returns>
		public static Behavior GetBehaviorByName(DomElement element, string name)
		{
			return null;
		}

		/// <summary>
		/// Gets an array of <see cref="Sys.UI.Behavior"/> objects that are of the specified type from the specified HTML Document Object Model (DOM) element. This method is static and can be invoked without creating an instance of the class.
		/// </summary>
		/// <param name="element">The <see cref="Sys.UI.DomElement"/> object to search.</param>
		/// <param name="type">The type of the <see cref="Sys.UI.Behavior"/> objects to find.</param>
		/// <returns>An array of all Behavior objects of the specified type that are associated with the specified DOM element, if found; otherwise, an empty array.</returns>
		public static Behavior[] GetBehaviorsByType(DomElement element, Type type)
		{
			return null;
		}

		/// <summary>
		/// Initializes the current <see cref="Sys.UI.Behavior"/> object.
		/// </summary>
		public void Initialize()
		{
		}
	}
}
