using HotBinder.Core.Keepers;
using HotBinder.Core.Layout;
using HotBinder.Core.Layout.Default;
using System.Windows.Forms;

namespace HotBinder
{
	public partial class AppHost : Form
	{
		public BaseLayoutView DefaultLayoutView;

		public void Initialize()
		{
			InitializeComponent();

			BaseLayoutView layoutView = DefaultLayoutView;
			if (DefaultLayoutView == null)
			{
				LayoutController layoutController = new DefaulLayoutController();
				layoutView = new DefaultLayoutView(layoutController);
			}

			HostPanel.Controls.Add(layoutView);

			ControllersKeeper.Instance.Scan();
			ControllersKeeper.Instance.PerformDefault(layoutView);
		}


	}
}
