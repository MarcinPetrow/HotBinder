using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BinderPlayground.Core
{
    sealed class RelayCommands : ICommand, INotifyPropertyChanged
    {
        readonly Action<object> execute;
        readonly Predicate<object> canExecute;

        public RelayCommands(Action<object> execute)
            : this(execute, null)
        {
            if (null == execute)
            {
                throw new NotImplementedException("Not implemented");
            }
            this.execute = execute;
        }

        public RelayCommands(Action<object> execute, Predicate<object> canExecute)
        {
            try
            {
                if (null == execute)
                {
                    this.execute = null;
                    throw new NotImplementedException("Not implemented");
                }
                this.execute = execute;
                this.canExecute = canExecute;
            }
            catch
            {
            }
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        private void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
