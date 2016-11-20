using HotBinder.Core;

namespace FileCopier.Views
{
	public partial class MainView : View
	{
		public MainView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}
	}
}