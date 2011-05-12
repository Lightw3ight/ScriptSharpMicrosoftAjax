using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Html;

namespace Sys.WebForms
{
	/// <summary>
	/// Used by the pageLoaded event of the <see cref="Sys.WebForms.PageRequestManager"/> class to send event data that represents the UpdatePanel controls that were updated and created in the most recent postback.
	/// http://msdn.microsoft.com/en-us/library/bb397476.aspx
	/// </summary>
	/// <remarks>
	/// The UpdatePanel control renders HTML <div> elements. The pageLoaded event contains information about which <div> elements on the page were updated and created. The panelsCreated property is an array of panel elements that were created as a result of the current asynchronous postback. The panelsUpdated property is an array of panels that were updated as a result of the current asynchronous postback.
	/// </remarks>
	[Imported]
	public class PageLoadedEventArgs : EventArgs
	{
		/// <summary>
		/// Gets a JSON data structure that contains data items that were registered by using the RegisterDataItem method of the ScriptManager class.
		/// </summary>
		/// <remarks>
		/// A page or control must be in partial-page rendering mode to register data items that use the RegisterDataItem method of the ScriptManager class. Use the IsInAsyncPostBack property to check whether the page is in partial-page rendering mode.
		/// The dataItems property returns a JSON data structure that contains name/value pairs. The name is the unique ID of the control that is used in the control parameter of the RegisterDataItem method. The value is the dataItem parameter of the RegisterDataItem method.
		/// </remarks>
		public Array DataItems
		{
			get { return null; }
		}

		/// <summary>
		/// Gets an array of HTML div elements that represent UpdatePanel controls that were created when the DOM was updated during the last asynchronous postback.
		/// </summary>
		/// <remarks>
		/// If an UpdatePanel control is updated as a result of a partial-page update, the array referenced in the panelsCreated property of the PageLoadedEventArgs class contains a reference to the corresponding div element. The pageLoaded event of the Sys.WebForms.PageRequestManager class uses a PageLoadedEventArgs object to return its event data.
		/// </remarks>
		public DivElement[] PanelsCreated
		{
			get { return null; }
		}

		/// <summary>
		/// Gets an array of HTML <div> elements that represent UpdatePanel controls that were updated when the DOM was updated during the last asynchronous postback.
		/// </summary>
		/// <remarks>
		/// If an UpdatePanel control is updated as a result of a partial-page update, the array referenced in the panelsUpdated property of the PageLoadedEventArgs class contains a reference to the corresponding <div> element. The pageLoaded event of the Sys.WebForms.PageRequestManager class uses a PageLoadedEventArgs object to return its event data.
		/// </remarks>
		public DivElement[] PanelsUpdated
		{
			get { return null; }
		}
	}
}
