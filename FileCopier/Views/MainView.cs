using HotBinder.Core;

namespace FileCopier.Views
{
	public partial class MainView : WinFormsView
	{
		public MainView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}
	}
}