using HotBinder.Core.Binding;
using System.Linq;
using System.Windows.Forms;

namespace HotBinder.Core.Layout.Default
{
	public abstract class BaseLayoutView : UserControl, ILayoutView
	{
		public void InitializeView(LayoutController layoutControllerContext)
		{
			ApplyDataContext(layoutControllerContext);
			Binder();
		}

		public abstract ViewHost GetHost();

		public void ApplyView(IView view)
		{
			try
			{
				SuspendLayout();
				var host = GetHost();
				host.Controls.Clear();
				var winFormsView = view as Control;
				if (winFormsView != null)
				{
					host.Controls.Add(winFormsView);
				}
				else
				{
					var wpfView = view as System.Windows.Controls.UserControl;
					if (wpfView != null)
					{
						var wpfHost = new System.Windows.Forms.Integration.ElementHost
						{
							Child = wpfView,
							AutoSize = true
						};
						host.Controls.Add(wpfHost);
					}
				}
			}
			finally
			{
				ResumeLayout();
			}
		}

		private void ApplyDataContext(LayoutController controllerContext)
		{
			foreach (var contextable in Controls.OfType<IContextable>())
			{
				contextable.Context = controllerContext;
			}
			controllerContext.NotifyAllProperties();
		}

		private void Binder()
		{
			foreach (var bindable in from object control in Controls select control as IBindable)
			{
				bindable?.BindAll();
			}
		}
	}
}