using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections;

namespace Sys.Net
{
	/// <summary>
	/// Provides the abstract base class from which network executors derive.
	/// http://msdn.microsoft.com/en-us/library/bb397434.aspx
	/// </summary>
	/// <remarks>
	/// The Sys.Net.WebRequestExecutor class is an abstract base class. You cannot instantiate it; instead, you must derive from it by implementing a network executor.
	/// Network requests issued by using the asynchronous communication layer flow through a network executor. Usually, executors interface with the network. However, you could create a storage executor that interacts with a local database instead of the network, or one that performs other work that involves an external resource.
	/// </remarks>
	[Imported]
	public abstract class WebRequestExecutor
	{
		/// <summary>
		/// Returns a value that indicates whether the executor was stopped.
		/// </summary>
		/// <remarks>
		/// When the current instance of the Sys.Net.WebRequestExecutor class is aborted, it must set its state to aborted and it must raise the completed event of the associated request object.
		/// </remarks>
		public bool Aborted
		{
			get { return false; }
		}

		/// <summary>
		/// Gets a value indicating whether the request completed successfully.
		/// </summary>
		/// <remarks>
		/// Successful completion usually means a well-formed response was received by the executor. If a response was received, the current instance of the Sys.Net.WebRequestExecutor class must set its state to completed. It must also raise the completed event of the associated request object.
		/// </remarks>
		public bool ResponseAvailable
		{
			get { return false; }
		}

		/// <summary>
		/// Gets the text representation of the response body.
		/// </summary>
		/// <remarks>
		/// When a request has completed successfully with valid response data, this property returns the text that is contained in the response body.
		/// </remarks>
		public string ResponseData
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the JSON-evaluated object from the response.
		/// </summary>
		public Dictionary Object
		{
			get { return null; }
		}

		/// <summary>
		/// Returns a value indicating whether the executor has started processing the request.
		/// </summary>
		/// <remarks>
		/// The executor returns true if substantial processing of the request has started. For executors that make network calls, substantial processing means that a network call has been started.
		/// </remarks>
		public bool Started
		{
			get { return false; }
		}

		/// <summary>
		/// Gets a success status code.
		/// </summary>
		/// <remarks>
		/// The statusCode property returns an integer that specifies that a request completed successfully and with valid response data.
		/// </remarks>
		public int StatusCode
		{
			get { return 0; }
		}

		/// <summary>
		/// Gets status information about a request that completed successfully.
		/// </summary>
		/// <remarks>
		/// The statusText property returns status information if a request completed successfully and with valid response data.
		/// </remarks>
		public string StatusText
		{
			get { return null; }
		}

		/// <summary>
		/// Gets a value indicating whether the request timed out.
		/// </summary>
		/// <remarks>
		/// Executors use the time-out information associated with the request to raise the completed event on the associated WebRequest object.
		/// </remarks>
		public bool TimedOut
		{
			get { return false; }
		}

		/// <summary>
		/// Attempts to get the response to the current request as an XMLDOM object.
		/// </summary>
		/// <remarks>
		/// If a request finished successfully with valid response data, this method tries to get the response as an XMLDOM object.
		/// </remarks>
		public string Xml
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the <see cref="Sys.Net.WebRequest"/> object associated with the executor.
		/// </summary>
		/// <remarks>
		/// The <see cref="Sys.Net.WebRequest"/> object associated with the current executor instance.
		/// </remarks>
		public WebRequest WebRequest
		{
			get { return null; }
		}

		/// <summary>
		/// Stops the pending network request issued by the executor.
		/// </summary>
		/// <remarks>
		/// The specifics of aborting a request vary depending on how an executor is implemented.
		/// However, all executors that derive from WebRequestExecutor must set their state to aborted and must raise the completed event of the associated Sys.Net.WebRequest object.
		/// </remarks>
		public void Abort()
		{

		}

		/// <summary>
		/// Instructs the executor to execute a Web request.
		/// </summary>
		/// <remarks>
		/// When this method is called, the executor packages the content of the Web request instance and initiates processing.
		/// This method is intended to be used by a custom executor.
		/// If you are implementing a custom executor, you instantiate the executor, assign it to the Web request instance, and then invoke the method on the executor instance.
		/// </remarks>
		public void ExecuteRequest()
		{

		}

		/// <summary>
		/// Gets all the response headers for the current request.
		/// </summary>
		/// <remarks>
		/// If a request finished successfully and with valid response data, this method returns all the response headers.
		/// </remarks>
		public string GetAllResponseHeaders()
		{
			return null;
		}

		/// <summary>
		/// Gets the value of the specified response header.
		/// </summary>
		/// <param name="header">The name of the specific header to return</param>
		/// <remarks>
		/// If the Web request completed successfully, you can call the getResponseHeader method to get the value of a specific response header based on the header's name. If the header does not exist, an empty string ("") is returned.
		/// You can call the getResponseHeader method only in code that is running inside a completed event handler, or running in the call stack of the completed event handler. An exception is thrown if you call the getResponseHeader method when the executor did not return successfully, or if the XmlHttpExecutor.responseAvailable property returns false. An exception is also thrown if you call the getResponseHeader method after the completed event has occurred. This is because the executor releases its reference to the browser's XMLHTTP object.
		/// </remarks>
		public string GetResponseHeader(string header)
		{
			return null;
		}
	}
}
