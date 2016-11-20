using HotBinder.Core;

namespace HelloWorld.Views
{
	public partial class SimpleView : View
	{
		public SimpleView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}
	}
}
