// PageRequestManager.cs
//

using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Sys.WebForms
{
	/// <summary>
	/// Manages partial-page updates of server UpdatePanel controls in the browser, and defines properties, events, and methods that can be used to customize a Web page by using client script.
	/// http://msdn.microsoft.com/en-us/library/bb311028.aspx
	/// </summary>
	[Imported]
	public class PageRequestManager : IDisposable
	{
		/// <summary>
		/// Returns the instance of the <see cref="Sys.WebForms.PageRequestManager"/> class for the page.
		/// </summary>
		/// <returns>The current instance of the PageRequestManager class. You do not create a new instance of the PageRequestManager class directly. Instead, an instance is available when partial-page rendering is enabled.</returns>
		public static PageRequestManager GetInstance()
		{
			return null;
		}

		/// <summary>
		/// Returns a value that indicates whether the <see cref="Sys.WebForms.PageRequestManager"/> object is processing a postback.
		/// </summary>
		/// <remarks>
		/// You can use the isInAsyncPostBack property to define how the PageRequestManager class behaves when a user submits a postback multiple times on a page.
		/// </remarks>
		public bool IsInAsyncPostBack
		{
			get { return true; }
		}

		/// <summary>
		/// Stops all updates that would occur as a result of an asynchronous postback.
		/// </summary>
		/// <remarks>
		/// The abortPostBack method stops the currently executing postback. To cancel a new postback, provide an event handler for the initializeRequest event and use the cancel event of the <see cref="Sys.CancelEventArgs"/> class.
		/// </remarks>
		public void AbortPostBack() { }

		/// <summary>
		/// Begins an asynchronous postback.
		/// </summary>
		/// <param name="updatePanelsToUpdate">(Optional) An array of UniqueID values or ClientID values for UpdatePanel controls that must be re-rendered.</param>
		/// <param name="eventTarget">(Optional) A string that contains the target of the event.</param>
		/// <param name="eventArgument">(Optional) A string that contains an argument for the event.</param>
		/// <param name="causesValidation">(Optional) true to cause validation.</param>
		/// <param name="validationGroup">(Optional) A string that contains the name of the validation group.</param>
		/// <remarks>
		/// Begins the process of an asynchronous postback.
		/// </remarks>
		public void BeginAsyncPostBack(string[] updatePanelsToUpdate, string eventTarget, string eventArgument, bool causesValidation, string validationGroup) { }

		/// <summary>
		/// Releases ECMAScript (JavaScript) resources and detaches events.
		/// </summary>
		/// <remarks>
		/// Use the dispose method to free client resources. The PageRequestManager instance calls the dispose method during the window.unload event of the browser. If you call the dispose method and then reference members of the PageRequestManager class, an error occurs. In typical page developer scenarios, you do not have to call the dispose method.
		/// </remarks>
		public void Dispose() { }

#pragma warning disable 67
		/// <summary>
		/// Raised during the initialization of the asynchronous postback.
		/// </summary>
		/// <remarks>
		/// The initializeRequest method is raised before processing of the asynchronous request starts. You can use this event to cancel a postback.
		/// </remarks>
		public event EventHandler<InitializeRequestEventArgs> InitializeRequest;

		/// <summary>
		/// Raised before the processing of an asynchronous postback starts and the postback request is sent to the server.
		/// </summary>
		/// <remarks>
		/// The beginRequest event is raised before the processing of an asynchronous postback starts and the postback is sent to the server. You can use this event to call custom script to set a request header or to start an animation that notifies the user that the postback is being processed.
		/// </remarks>
		public event EventHandler<BeginRequestEventArgs> BeginRequest;

		/// <summary>
		/// Raised after an asynchronous postback is finished and control has been returned to the browser.
		/// </summary>
		/// <remarks>
		/// The endRequest event is raised after an asynchronous postback is finished and control has been returned to the browser. You can use this event to provide a notification to users or to log errors.
		/// </remarks>
		public event EventHandler<EndRequestEventArgs> EndRequest;

		/// <summary>
		/// Raised after the response from the server to an asynchronous postback is received but before any content on the page is updated.
		/// </summary>
		/// <remarks>
		/// The pageLoading event is raised after the response from the server to an asynchronous postback is received but before any content on the page is updated. You can use this event to provide a custom transition effect for updated content.
		/// </remarks>
		public event EventHandler<PageLoadingEventArgs> PageLoading;

		/// <summary>
		/// Raised after all content on the page is refreshed as a result of either a synchronous or an asynchronous postback.
		/// </summary>
		/// <remarks>
		/// The pageLoaded event is raised after all content on the page is refreshed, whether it was refreshed because of a synchronous (full-page) postback or an asynchronous postback. You can use this event to provide a custom transition effect for updated content.
		/// </remarks>
		public event EventHandler<PageLoadedEventArgs> PageLoaded;

#pragma warning restore 67
	}
}
