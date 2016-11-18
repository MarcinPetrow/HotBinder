using BinderPlayground.Core;

namespace FileCopier.Views
{
	public partial class MainView : View
	{
		public MainView(ViewModel model)
		{
			InitializeComponent();
			InitializeView(model);
		}
	}
}