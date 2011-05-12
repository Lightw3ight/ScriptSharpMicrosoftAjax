using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sys
{
	[Imported]
	public class EventArgs
	{
		public static EventArgs Empty
		{
			get { return null; }
			set{}
		}
	}
}
