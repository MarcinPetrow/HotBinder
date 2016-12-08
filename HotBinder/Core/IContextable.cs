using HotBinder.Core.Abilities;

namespace HotBinder.Core
{
	public interface IContextable
	{
		INotificator Context { get; set; }
	}
}