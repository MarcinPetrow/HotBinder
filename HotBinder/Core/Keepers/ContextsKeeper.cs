using HotBinder.Core.Abilities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotBinder.Core.Keepers
{
	public class ContextsKeeper
	{
		#region Singleton

		private static volatile ContextsKeeper instance;
		private static readonly object SyncRoot = new object();

		private ContextsKeeper()
		{
			contextsRegistry = new Dictionary<object, INotificator>();
		}

		public static ContextsKeeper Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							instance = new ContextsKeeper();
						}
					}
				}

				return instance;
			}
		}

		#endregion Singleton

		private readonly Dictionary<object, INotificator> contextsRegistry;

		public void Register(object target, INotificator context)
		{
			contextsRegistry[target] = context;
		}

		public INotificator GetContext(Control target)
		{
			if (target == null)
			{
				return null;
			}

			if (contextsRegistry.ContainsKey(target))
			{
				return contextsRegistry[target];
			}

			if (target.Parent != null)
			{
				return GetContext(target.Parent);
			}
			return null;
		}
	}
}
