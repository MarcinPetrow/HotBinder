using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BinderPlayground.Core
{
    public class ViewModel : INotifyPropertyChanged
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

        public void NotifyProperty(string propertyName)
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