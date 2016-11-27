using HotBinder.Core;

namespace MixinExample.Views
{
	/// <summary>
	/// Interaction logic for SimpleView.xaml
	/// </summary>
	public partial class SimpleWPFView
	{
		public SimpleWPFView(Controller controller)
		{
			InitializeComponent();
			InitializeView(controller);
		}
	}
}
