using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BinderPlayground.Core;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.ComponentModel;

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
        private ICommand addItemAction;
        private BindingList<string> items;

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

        public ICommand AddItemAction
        {
            get { return addItemAction; }
            set
            {
                SetProperty(ref addItemAction, value);
            }
        }

        public BindingList<string> Items {
            get { return items; }
            set
            {
                SetProperty(ref items, value);
            }       
        }

        public SampleModel()
        {
            SampleAction = new RelayCommands(SampleActionExecute);
            NewWindowAction = new RelayCommands(NewWindowActionExecute);
            DuplicateWindowAction = new RelayCommands(DuplicateWindowActionExecute);
            AddItemAction = new RelayCommands(AddItemActionExecute);

            
            Items = new BindingList<string>();
        }

        private void AddItemActionExecute(object obj)
        {
            Items.Add("Item");
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