namespace HotBinder.Core.Layout.Default
{

	[Layout]
	public partial class DefaultLayoutView : BaseLayoutView
	{
		public DefaultLayoutView(LayoutController layoutControllerContext)
		{
			InitializeComponent();
			InitializeView(layoutControllerContext);
		}

		public override ViewHost GetHost()
		{
			return Host;
		}
	}
}
