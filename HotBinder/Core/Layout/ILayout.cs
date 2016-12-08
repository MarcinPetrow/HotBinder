using HotBinder.Core.Abilities;

namespace HotBinder.Core.Layout
{
	public interface ILayout : INotificator
	{
		void InitializeLayout(AppHost host);

		ViewHost GetViewContainer();

		void ChangeLayout(string layoutName);
	}
}