namespace HotBinder.Core.Keepers
{
	public class ControllersKeeper
	{
		#region Singleton

		private static volatile ControllersKeeper instance;
		private static readonly object SyncRoot = new object();

		private ControllersKeeper()
		{

		}

		public static ControllersKeeper Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							instance = new ControllersKeeper();
						}
					}
				}

				return instance;
			}
		}

		#endregion Singleton

		public Controller GetController(string controllerName)
		{
			var defaultController = System.Reflection.Assembly.GetEntryAssembly().CreateInstance(controllerName) as Controller;

			return defaultController;
		}
	}
}
