using System.Runtime.CompilerServices;

namespace Sys
{
	/// <summary>
	/// Provides information about the current Web browser.
	/// http://msdn.microsoft.com/en-us/library/cc679064.aspx
	/// </summary>
	/// <remarks>
	/// The Sys.Browser object determines which browser is being used and provides some information about it. You can use this object to help customize your code to the unique requirements or capabilities of the browser.
	/// </remarks>
	[ScriptName("Browser"), Imported]
	public static class BrowserDetails
	{
		[PreserveCase]
		public const object InternetExplorer = null;

		[PreserveCase]
		public const object Firefox = null;

		[PreserveCase]
		public const object Safari = null;

		[PreserveCase]
		public const object Opera = null;

		[PreserveCase]
		public const object Chrome = null;

		/// <summary>
		/// Gets an object that represents the user agent of the browser.
		/// </summary>
		[IntrinsicProperty]
		public static object Agent
		{
			get { return null; }
		}

		/// <summary>
		/// Gets a value that indicates the document compatibility mode of the browser
		/// </summary>
		[IntrinsicProperty]
		public static int DocumentMode
		{
			get { return 0; }
		}

		/// <summary>
		/// Returns a value that indicates whether the browser supports debug statements
		/// </summary>
		[IntrinsicProperty]
		public static bool HasDebuggerStatement
		{
			get { return false; }
		}

		/// <summary>
		/// Gets the name of the browser
		/// </summary>
		[IntrinsicProperty]
		public static string Name
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the version number of the browser.
		/// </summary>
		[IntrinsicProperty]
		public static int Version
		{
			get { return 0; }
		}
	}
}
