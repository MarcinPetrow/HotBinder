using System.ComponentModel;

namespace HotBinder.Core.Abilities
{
	public interface INotificator : INotifyPropertyChanged
	{
		void NotifyAllProperties();
		void NotifyProperty(string propertyName);
	}
}