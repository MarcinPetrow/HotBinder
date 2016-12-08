using HotBinder.Core.Keepers.Entries;
using HotBinder.Core.Layout.Default;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace HotBinder.Core.Keepers
{
	public class LayoutKeeper
	{
		#region Singleton

		private static volatile LayoutKeeper instance;
		private static readonly object SyncRoot = new object();

		private LayoutKeeper()
		{
			layoutsRegistry = new Dictionary<string, LayoutEntry>();
		}

		public static LayoutKeeper Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							instance = new LayoutKeeper();
						}
					}
				}

				return instance;
			}
		}

		#endregion Singleton

		private readonly Dictionary<string, LayoutEntry> layoutsRegistry;

		private void Scan(Assembly assembly)
		{
			var layoutTypes = assembly.GetTypes().Where(t => typeof(BaseLayout).IsAssignableFrom(t));


			foreach (var layoutType in layoutTypes)
			{
				var typeName = layoutType.Name;
				if (layoutsRegistry.ContainsKey(typeName))
				{
					throw new DuplicateNameException(string.Format($"Exists more than one layout type with name {0}", typeName));
				}
				var layoutEntry = new LayoutEntry
				{
					InstanceType = layoutType,
					Name = layoutType.Name,
					Instance = assembly.CreateInstance(layoutType.FullName) as BaseLayout
				};
				layoutsRegistry.Add(layoutType.Name, layoutEntry);
			}
		}

		internal void Scan()
		{
			layoutsRegistry.Clear();

			Scan(Assembly.GetEntryAssembly());
			Scan(Assembly.GetExecutingAssembly());
		}

		public BaseLayout GetLayout(string layoutName)
		{
			return GetLayoutEntry(layoutName).Instance;
		}

		public LayoutEntry GetLayoutEntry(string layoutName)
		{
			return layoutsRegistry.FirstOrDefault(entry => entry.Value != null && entry.Value.Name == layoutName).Value;
		}
	}
}
