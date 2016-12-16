using HotBinder.Core;

namespace HelloWorld.Views
{
	public partial class SimpleView : WinFormsView
	{
		public SimpleView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{

		}
	}
}
