using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BinderPlayground.Core;
using System.Windows.Forms;

namespace BinderPlayground.App
{
    public class SampleModel : Model
    {
        private bool isChecked;
        private bool isEnabled;
        private string name;
        private ICommand sampleAction;
        private ICommand newWindowAction;
        private ICommand duplicateWindowAction;

        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);               
            }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                SetProperty(ref isChecked, value);
            }
        }

        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                SetProperty(ref isEnabled, value);
            }
        }

        public ICommand SampleAction
        {
            get { return sampleAction; }
            set
            {
                SetProperty(ref sampleAction, value);
            }
        }

        public ICommand NewWindowAction
        {
            get { return newWindowAction; }
            set
            {
                SetProperty(ref newWindowAction, value);
            }
        }

        public ICommand DuplicateWindowAction
        {
            get { return duplicateWindowAction; }
            set
            {
                SetProperty(ref duplicateWindowAction, value);
            }
        }

        public SampleModel()
        {
            SampleAction = new RelayCommands(SampleActionExecute);
            NewWindowAction = new RelayCommands(NewWindowActionExecute);
            DuplicateWindowAction = new RelayCommands(DuplicateWindowActionExecute);
        }

        private void DuplicateWindowActionExecute(object obj)
        {
            var view = new SampleView(this);
            Form newWindow = new Form();
            newWindow.Controls.Add(view);
            newWindow.Show();
        }

        private void NewWindowActionExecute(object obj)
        {
            var view = new SampleView(new SampleModel());
            Form newWindow = new Form();
            newWindow.Controls.Add(view);
            newWindow.Show();
        }

        private void SampleActionExecute(object obj)
        {
            MessageBox.Show("Tada!");
        }
    }
}