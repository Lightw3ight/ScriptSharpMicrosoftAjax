using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys
{
	/// <summary>
	/// http://msdn.microsoft.com/en-us/library/bb397516.aspx
	/// </summary>
	/// <remarks>
	/// The Component class provides the base class for all ASP.NET AJAX client controls, behaviors, and non-visual components on the page. It also provides the static create method, available as Sys.Component.Create or as the $create shortcut method, as a means to add an instance of a component, control, or behavior to your application. The create method is preferred over Sys.Application.addComponent because it sets all the properties that are required to define a component instance on page.
	/// The Component class implements the INotifyDisposing interface. Any object in your application can subscribe to the disposing event of a component and use the event as a signal to dispose itself or to do other work. The Component class also implements the INotifyPropertyChanged interface, and therefore raises propertyChanged events. These events can be handled internally, subscribed to by other components, or both.
	/// For information about how to create custom components that derive from Component, see the following topics.
	/// </remarks>
	[Imported]
	public class Component : IDisposable, INotifyDisposing
	{
		/// <summary>
		/// Gets an <see cref="Sys.EventHandlerList"/> object that contains references to all the event handlers that are mapped to the current component's events.
		/// </summary>
		public EventHandlerList Events
		{
			get { return null; }
		}

		/// <summary>
		/// Gets or sets the ID of the current <see cref="Sys.Component"/> object.
		/// </summary>
		/// <remarks>
		/// The <c>Id</c> property must be set before the component is registered with the application.
		/// </remarks>
		public virtual string Id
		{
			get { return null; }
			set { }
		}

		/// <summary>
		/// Gets a value indicating whether the current <see cref="Sys.Component"/> object is initialized.
		/// </summary>
		public bool IsInitialized
		{
			get { return false; }
		}

		/// <summary>
		/// Gets a value indicating whether the current <see cref="Sys.Component"/> object is updating.
		/// </summary>
		public bool IsUpdating
		{
			get { return false; }
		}

		/// <summary>
		/// Raised when the <c>Dispose</c> method is called for a component.
		/// </summary>
		public event EventHandler Disposing;

		/// <summary>
		/// Raised when the raisePropertyChanged method of the current Component object is called.
		/// </summary>
		public event EventHandler<PropertyChangedEventArgs> PropertyChanged;

		/// <summary>
		/// Called by the <c>Create</c> method to indicate that the process of setting properties of a component instance has begun.
		/// </summary>
		/// <remarks>
		/// The <c>BeginUpdate</c> method sets the <c>IsUpdating</c> property of the current <see cref="Sys.Component"/> object to true. Component developers can override the <c>BeginUpdate</c> method in a derived class to add custom update logic.
		/// </remarks>
		public void BeginUpdate() { }

		/// <summary>
		/// Removes the component from the application.
		/// </summary>
		/// <remarks>
		/// The dispose method releases all resources from the <see cref="Sys.UI.Component"/> object, raises the <c>Disposing</c> event, and unregisters the component from the application.
		/// </remarks>
		public virtual void Dispose() { }

		/// <summary>
		/// Called by the <c>Create</c> method to indicate that the process of setting properties of a component instance has finished.
		/// </summary>
		/// <remarks>
		/// The <c>EndUpdate</c> method sets the <c>IsUpdating</c> property of the current Component object to false, calls the <c>Initialize</c> method if it has not already been called, and then calls the <c>Updated</c> method.
		/// </remarks>
		public void EndUpdate() { }

		/// <summary>
		/// Initializes the current <see cref="Sys.Component"/> object.
		/// </summary>
		/// <remarks>
		/// The <c>Initialize</c> method sets the <c>IsInitialized</c> property of the current <see cref="Sys.Component"/> object to true. This function is called by the <c>Create</c> method ($create) and overridden in derived classes to initialize the component.
		/// </remarks>
		public virtual void Initialize() { }

		/// <summary>
		/// Called by the <c>EndUpdate</c> method as a placeholder for additional logic in derived classes.
		/// </summary>
		/// <remarks>
		/// Override the <c>Updated</c> method in a derived class to add custom post-update logic.
		/// </remarks>
		public virtual void Updated() { }
	}
}
