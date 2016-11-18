using BinderPlayground.Core;

namespace HelloWorld.Views
{
	public partial class SimpleView : View
	{
		public SimpleView(ViewModel viewModel)
		{
			InitializeComponent();
			InitializeView(viewModel);
		}
	}
}
