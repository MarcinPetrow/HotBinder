using HotBinder.Core;
using HotBinder.Core.Keepers;
using HotBinder.Core.Layout.Default;
using System;
using System.Windows.Forms;

namespace HotBinder
{
	public partial class AppHost : Form
	{
		public BaseLayout CurrentLayout;

		public void Initialize()
		{
			InitializeComponent();

			ControllersKeeper.Instance.Scan();
			LayoutKeeper.Instance.Scan();

			CurrentLayout = new DefaultLayout();
			CurrentLayout.InitializeLayout(this);
			HostPanel.Controls.Add(CurrentLayout);

			ControllersKeeper.Instance.PerformDefault(this);
		}


		public void ChangeLayout(string layoutName)
		{
			BaseLayout layoutView = LayoutKeeper.Instance.GetLayout(layoutName);
			if (layoutView == null)
			{
				throw new NullReferenceException();
			}

			if (CurrentLayout == layoutView)
			{
				return;
			}

			layoutView.InitializeLayout(this);

			HostPanel.SuspendLayout();
			HostPanel.Controls.Clear();
			HostPanel.Controls.Add(layoutView);
			HostPanel.Controls.Add(new CheckBox());
			HostPanel.ResumeLayout(true);

			CurrentLayout = layoutView;
		}

		public void ApplyView(IView view)
		{
			try
			{
				SuspendLayout();
				var container = CurrentLayout.GetViewContainer();
				container.Controls.Clear();
				var winFormsView = view as Control;
				if (winFormsView != null)
				{
					container.Controls.Add(winFormsView);
				}
				else
				{
					var wpfView = view as System.Windows.Controls.UserControl;
					if (wpfView == null)
					{
						return;
					}
					var wpfHost = new System.Windows.Forms.Integration.ElementHost
					{
						Child = wpfView,
						AutoSize = true
					};
					container.Controls.Add(wpfHost);
				}
			}
			finally
			{
				ResumeLayout();
			}
		}

		public void ApplyView(IView view, string layoutName)
		{
			ChangeLayout(layoutName);
			ApplyView(view);
		}
	}
}
