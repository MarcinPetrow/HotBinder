using HotBinder.Core.Keepers;
using System.Windows.Forms;
using View = HotBinder.Core.View;

namespace HotBinder
{
	public partial class AppHost : Form
	{
		public string DefaultController { get; set; }

		public void Initialize()
		{
			InitializeComponent();

			var controller = ControllersKeeper.Instance.GetController(DefaultController);
			controller.Host = this;

			var indexMethod = controller.GetType().GetMethod("Index");

			indexMethod.Invoke(controller, null);
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
