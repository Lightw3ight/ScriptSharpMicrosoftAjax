using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Html;
using Sys.Net;
using System.Collections;

namespace Sys.WebForms
{
	/// <summary>
	/// Used by the endRequest event of the <see cref="Sys.WebForms.PageRequestManager"/> class to pass argument information to event handlers. The endRequest event is raised just after the postback request has finished processing.
	/// http://msdn.microsoft.com/en-us/library/bb397499.aspx
	/// </summary>
	/// <remarks>
	/// An EndRequestEventArgs object is returned as a parameter in an event handler. You can use its error property to determine whether an error occurred and to obtain details about the error. You can also use the errorHandled property to determine whether the error has already been handled and to indicate that you have handled the error.
	/// </remarks>
	[Imported]
	public class EndRequestEventArgs : EventArgs
	{
		/// <summary>
		/// Gets a JSON data structure that contains data items that were registered by using the RegisterDataItem method of the ScriptManager class.
		/// </summary>
		/// <remarks>
		/// A page or control must be in partial-page rendering mode to register data items by using the RegisterDataItem method of the ScriptManager class. Use the IsInAsyncPostBack property to check whether the page is in partial-page rendering mode.
		/// The dataItems property returns a JSON data structure that contains name/value pairs. The name is the unique ID of the control that is used in the control parameter of the RegisterDataItem method. The value is the dataItem parameter of the RegisterDataItem method.
		/// </remarks>
		public Dictionary DataItems
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the Error object.
		/// </summary>
		/// <remarks>
		/// The JavaScript Error object exposes several properties that define the error. The Microsoft Ajax Library provides additional functions for the Error object.
		/// </remarks>
		public Exception Error
		{
			get { return null; }
		}

		/// <summary>
		/// Get or sets a value that indicates whether the error has been handled.
		/// </summary>
		/// <remarks>
		/// Use this property to determine whether an asynchronous postback error has already been handled. If it has not and if you want to take action on the error, you can set the error as handled.
		/// </remarks>
		public bool ErrorHandled
		{
			get { return false; }
			set { }
		}

		/// <summary>
		/// Gets a response object that is represented by the <see cref="Sys.Net.WebRequestExecutor"/> class.
		/// </summary>
		/// <remarks>
		/// Use the response object's aborted property to determine whether the response was stopped.
		/// </remarks>
		public WebRequestExecutor Response 
		{
			get { return null; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Sys.WebForms.EndRequestEventArgs"/> class.
		/// </summary>
		/// <param name="error">An error object.</param>
		/// <param name="dataItems">An object containing data items.</param>
		/// <param name="response">An object of type Sys.Net.WebRequestExecutor</param>
		public EndRequestEventArgs(Exception error, Dictionary dataItems, WebRequestExecutor response)
		{

		}
	}
}
