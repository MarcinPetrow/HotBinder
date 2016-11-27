using HotBinder.Core;
using HotBinder.Core.Keepers;
using System.Windows.Forms;
using UserControl = System.Windows.Controls.UserControl;

namespace HotBinder
{
	public partial class AppHost : Form
	{
		public void Initialize()
		{
			InitializeComponent();

			ControllersKeeper.Instance.Scan();
			ControllersKeeper.Instance.PerformDefault(this);
		}

		public void ApplyView(IView view)
		{
			try
			{
				SuspendLayout();

				ViewPanel.Controls.Clear();
				var winFormsView = view as Control;
				if (winFormsView != null)
				{
					ViewPanel.Controls.Add(winFormsView);
				}
				else
				{
					var wpfView = view as UserControl;
					if (wpfView != null)
					{
						var wpfHost = new System.Windows.Forms.Integration.ElementHost
						{
							Child = wpfView,
							AutoSize = true
						};
						ViewPanel.Controls.Add(wpfHost);
					}
				}
			}
			finally
			{
				ResumeLayout();
			}
		}
	}
}
