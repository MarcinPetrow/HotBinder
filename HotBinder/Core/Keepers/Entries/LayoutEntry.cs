using HotBinder.Core.Layout.Default;
using System;

namespace HotBinder.Core.Keepers.Entries
{
	public class LayoutEntry
	{
		public BaseLayout Instance { get; set; }

		public string Name { get; set; }

		public Type InstanceType { get; set; }
	}
}
