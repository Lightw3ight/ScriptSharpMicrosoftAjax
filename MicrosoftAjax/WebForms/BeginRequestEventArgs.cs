using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Html;
using Sys.Net;

namespace Sys.WebForms
{
	/// <summary>
	/// Used by the beginRequest event of the <see cref="Sys.WebForms.PageRequestManager"/> class to pass argument information to event handlers. The beginRequest event is raised just before the postback request is made.
	/// http://msdn.microsoft.com/en-us/library/bb384003.aspx
	/// </summary>
	/// <remarks>
	/// Event handlers can use the request property to access the request object and the postBackElement property to determine the element that caused the postback.
	/// </remarks>
	[Imported]
	public class BeginRequestEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the postback element that initiated the asynchronous postback. This property is read-only.
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
		/// Gets a list of UniqueID values for UpdatePanel controls that should re-render their content, as requested by the client.
		/// </summary>
		/// <remarks>
		/// Server-side processing might update additional UpdatePanel controls.
		/// </remarks>
		public string[] UpdatePanelsToUpdate
		{
			get { return null; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Sys.WebForms.BeginRequestEventArgs"/> class.
		/// </summary>
		/// <param name="request">A Sys.Net.WebRequest representing the web request for the EventArgs.</param>
		/// <param name="postBackElement">The postback element that initiated the async postback.</param>
		/// <param name="updatePanelsToUpdate">(Optional) A list of UniqueIDs for UpdatePanel controls that are requested to update their rendering by the client. Server-side processing may update additional UpdatePanels.</param>
		public BeginRequestEventArgs(WebRequestExecutor request, Element postBackElement, string[] updatePanelsToUpdate) { }
	}
}
