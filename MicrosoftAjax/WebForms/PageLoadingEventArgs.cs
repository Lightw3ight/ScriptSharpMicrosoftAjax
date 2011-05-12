using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Html;

namespace Sys.WebForms
{
	/// <summary>
	/// Used by the pageLoading event of the <see cref="Sys.WebForms.PageRequestManager"/> class to send event data that represents the UpdatePanel controls being updated and deleted as a result of the most recent postback.
	/// http://msdn.microsoft.com/en-us/library/bb310960.aspx
	/// </summary>
	/// <remarks>
	/// The UpdatePanel control renders <div> elements. After a postback, the pageLoading event contains information about which <div> elements on the page were updated and created. The panelsDeleting property is an array of <div> elements that are being deleted. The panelsUpdating property is an array of <div> elements that are being updated.
	/// </remarks>
	[Imported]
	public class PageLoadingEventArgs : EventArgs
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
		/// Gets an array of HTML <div> elements that represent UpdatePanel controls that will be deleted from the DOM as a result of the current asynchronous postback.
		/// </summary>
		/// <remarks>
		/// If the contents of an UpdatePanel control will be deleted as the result of a partial-page update, the array that is referenced in the panelsDeleting property of the PageLoadingEventArgs class contains a reference to the corresponding <div> element. The pageLoading event of the Sys.WebForms.PageRequestManager class uses a PageLoadingEventArgs object to return its event data.
		/// </remarks>
		public DivElement[] PanelsDeleting
		{
			get { return null; }
		}

		/// <summary>
		/// Gets an array of HTML <div> elements that represent UpdatePanel controls that will be updated in the DOM as a result of the current asynchronous postback.
		/// </summary>
		/// <remarks>
		/// If the contents of any UpdatePanel controls will be updated as the result of a partial-page update, the panelsUpdating property contains an array that references the corresponding <div> elements. The pageLoading event of the Sys.WebForms.PageRequestManager class uses a PageLoadingEventArgs object to return its event data.
		/// </remarks>
		public DivElement[] PanelsUpdating
		{
			get { return null; }
		}
	}
}
