using HotBinder.Core.Binding;
using System.Linq;
using System.Windows.Forms;

namespace HotBinder.Core
{
	public class WinFormsView : UserControl, IView
	{
		public void InitializeView(Controller controllerContext)
		{
			ApplyDataContext(controllerContext);
			Binder();
		}

		private void ApplyDataContext(Controller controllerContext)
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