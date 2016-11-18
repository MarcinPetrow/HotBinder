using BinderPlayground.Core;
using System.Windows.Forms;
using View = BinderPlayground.Core.View;

namespace HotBinder
{
	public partial class AppHost : Form
	{
		public string DefaultController { get; set; }

		public AppHost()
		{
		}

		public void Initialize()
		{
			InitializeComponent();

			var controller = GetDefaultController();
			controller.Host = this;

			var indexMethod = controller.GetType().GetMethod("Index");

			indexMethod.Invoke(controller, null);
		}

		public Controller GetDefaultController()
		{
			var defaultController = System.Reflection.Assembly.GetEntryAssembly().CreateInstance(DefaultController) as Controller;

			return defaultController;
		}

		public void ApplyView(View view)
		{
			try
			{
				SuspendLayout();

				ViewPanel.Controls.Clear();
				ViewPanel.Controls.Add(view);
			}
			finally
			{
				ResumeLayout();
			}
		}
	}
}
