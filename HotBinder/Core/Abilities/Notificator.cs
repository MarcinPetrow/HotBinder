using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HotBinder.Core.Abilities
{
	public class Notificator : INotificator
	{
		public bool Notifiable = true;

		public void NotifyAllProperties()
		{
			foreach (var propertyInfo in GetType().GetProperties())
			{
				if (!propertyInfo.CanRead)
				{
					continue;
				}
				var propertyName = propertyInfo.Name;
				OnPropertyChanged(propertyName);
			}
		}

		public void NotifyProperty([CallerMemberName]string propertyName = null)
		{
			if (Notifiable)
			{
				OnPropertyChanged(propertyName);
			}
		}

		#region Property changed

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value))
			{
				return;
			}

			field = value;
			NotifyProperty(propertyName);
		}

		#endregion
	}
}
