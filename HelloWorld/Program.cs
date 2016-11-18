using HotBinder;
using System;
using System.Windows.Forms;

namespace HelloWorld
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var host = new AppHost()
			{
				DefaultController = "HelloWorld.Controllers.MainController"
			};
			host.Initialize();

			Application.Run(host);
		}


	}
}
