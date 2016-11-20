using HotBinder.Core;

namespace Playground.App
{
	public partial class SampleView : View
	{
		public SampleView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}
	}
}