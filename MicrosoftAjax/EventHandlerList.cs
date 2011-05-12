using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys
{
	/// <summary>
	/// Creates a dictionary of client events for a component, with event names as keys and the associated handlers as values.
	/// http://msdn.microsoft.com/en-us/library/bb383996.aspx
	/// </summary>
	/// <remarks>
	/// Use the <see cref="Sys.EventHandlerList"/> class to handle client events in custom ASP.NET AJAX components. The <see cref="Sys.EventHandlerList"/> class provides a central reference location for events and their handlers in a script block, component, or script resource file.
	/// To raise an event, call the getHandler method with the id parameter set to the identifier of the event to raise. You then call the method returned by getHandler. This calls all the handlers for the event in order.
	/// In a class derived from <see cref="Sys.Component"/>, you can access a run-time instance of the EventHandlerList by using the events property of the Sys.Component base class. For more information, see Sys.Component.events Property.
	/// </remarks>
	[Imported]
	public class EventHandlerList
	{
		/// <summary>
		/// Returns a single method that can be invoked to call all handlers sequentially for the specified event.
		/// </summary>
		/// <param name="id">The ID for the specified event.</param>
		/// <returns>A single method that can be invoked to call all handlers sequentially for the specified event.</returns>
		/// <remarks>
		/// Call the getHandler method to raise events in an EventHandlerList object. You first call the getHandler method with the id parameter set to the identifier of the event to raise. You then call the method returned by getHandler to call all the handlers for the event in order.
		/// You should call getHandler immediately before you call the returned method, in case there is any change to the contents of the Sys.EventHandlerList object.
		/// The getHandler method raises only the events declared in a EventHandlerList instance and will not include handlers declared elsewhere.
		/// </remarks>
		public EventHandler GetHandler(string id) { return null; }

		/// <summary>
		/// Attaches a handler to an event in an <see cref="Sys.EventHandlerList"/> instance and adds the event to the list if it is not already present.
		/// </summary>
		/// <param name="id">A string that specifies the event.</param>
		/// <param name="handler">The name of the method to handle the event.</param>
		/// <remarks>
		/// Use the addHandler method to programmatically attach handlers to events in Microsoft Ajax script components. In the Microsoft Ajax component event model, client events reside in an EventHandlerList object. Handlers are created and assigned to the event by using the addHandler method. You then raise the events by calling the method that is returned by the getHandler method.
		/// If the id value that you pass to addHandler is already in the EventHandlerList instance, the method specified by handler is added to any handlers already associated with the event. Otherwise, a new event that has the specified ID and handler is added to the EventHandlerList object.
		/// </remarks>
		public void AddHandler(string id, EventHandler handler) { }

		/// <summary>
		/// Removes an event handler from an event in an <see cref="Sys.EventHandlerList"/> instance.
		/// </summary>
		/// <param name="id">The ID for the event.</param>
		/// <param name="handler">The handler to remove from the event.</param>
		/// <remarks>
		/// Use the removeHandler method to remove an event handler from an event defined in an EventHandlerList object. If the event has only one handler when removeHandler is called, the event will continue to exist as a placeholder in the EventHandlerList instance.
		/// The addHandler and removeHandler methods also enable you to dynamically change an event in a script component at run time. For example, you can remove a handler from the list during its execution so that it runs only the first time the event is raised.
		/// </remarks>
		public void RemoveHandler(string id, EventHandler handler) { }
	}
}
