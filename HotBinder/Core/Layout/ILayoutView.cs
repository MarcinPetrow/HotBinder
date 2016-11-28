namespace HotBinder.Core.Layout
{
	public interface ILayoutView
	{
		void InitializeView(LayoutController layoutControllerContext);

		ViewHost GetHost();

		void ApplyView(IView view);
	}
}