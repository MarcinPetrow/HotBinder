using System.Windows.Controls;

namespace HotBinder.Core
{
	public class WpfView : UserControl, IView
	{
		public void InitializeView(Controller controllerContext)
		{
			DataContext = controllerContext;
		}

	}
}
