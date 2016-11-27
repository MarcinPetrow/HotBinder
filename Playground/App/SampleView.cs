using HotBinder.Core;

namespace Playground.App
{
	public partial class SampleView : WinFormsView
	{
		public SampleView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}
	}
}