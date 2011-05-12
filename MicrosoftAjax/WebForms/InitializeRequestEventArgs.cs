using System;
using System.Collections.Generic;
using System.Linq;
using System.Html;
using System.Runtime.CompilerServices;
using Sys.Net;

namespace Sys.WebForms
{
	/// <summary>
	/// Provides a class that is used by the initializeRequest event of the <see cref="Sys.WebForms.PageRequestManager"/> class to pass argument information to event handlers.
	/// http://msdn.microsoft.com/en-us/library/bb311030.aspx
	/// </summary>
	/// <remarks>
	/// Event handlers can use the request property to access the request object and use the postBackElement property to determine which element caused the postback.
	/// The initializeRequest event of the PageRequestManager class is raised before processing of the asynchronous request starts.
	/// </remarks>
	[Imported]
	public class InitializeRequestEventArgs : CancelEventArgs
	{
		/// <summary>
		/// Gets the postback element that initiated the asynchronous postback.
		/// </summary>
		public Element PostBackElement
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the request object that represents the current postback.
		/// </summary>
		public WebRequestExecutor Request
		{
			get { return null; }
		}

		/// <summary>
		/// Gets or sets a list of UniqueID values for UpdatePanel controls that should re-render their content, as requested by the client.
		/// </summary>
		/// <remarks>
		/// The returned array can be modified by a client event handler to add or remove UpdatePanel controls that should re-render their content dynamically. Server processing can also modify the array.
		/// </remarks>
		public string[] UpdatePanelsToUpdate
		{
			get { return null; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Sys.WebForms.InitializeRequestEventArgs"/> class.
		/// </summary>
		/// <param name="request">A Sys.Net.WebRequest object that represents the Web request for the EventArgs object.</param>
		/// <param name="postBackElement">The postback element that initiated the asynchronous postback.</param>
		/// <param name="updatePanelsToUpdate">(Optional) A list of UniqueID values for UpdatePanel controls that are being requested to update their rendering by the client. Server-side processing might update additional UpdatePanel controls.</param>
		public InitializeRequestEventArgs(WebRequestExecutor request, Element postBackElement, string[] updatePanelsToUpdate) { }
	}
}
