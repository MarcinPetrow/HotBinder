using BinderPlayground.Core;
using HotBinder.Core.Controls.Components;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

namespace BinderPlayground.App
{
	public class SampleModel : ViewModel
	{
		private bool isChecked;
		private bool optionA;
		private bool optionB;
		private bool optionC;
		private bool isEnabled;
		private string name;
		private ICommand sampleAction;
		private ICommand newWindowAction;
		private ICommand duplicateWindowAction;
		private ICommand addItemAction;
		private BindingList<HStringListItem> items;
		private int selectedIndex;
		private string selectedItem;
		private DateTime sampleDate;

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

		public bool OptionA
		{
			get { return optionA; }
			set
			{
				SetProperty(ref optionA, value);
			}
		}

		public bool OptionB
		{
			get { return optionB; }
			set
			{
				SetProperty(ref optionB, value);
			}
		}

		public bool OptionC
		{
			get { return optionC; }
			set
			{
				SetProperty(ref optionC, value);
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

		public BindingList<HStringListItem> Items
		{
			get { return items; }
			set
			{
				SetProperty(ref items, value);
			}
		}

		public int SelectedIndex
		{
			get { return selectedIndex; }
			set
			{
				SetProperty(ref selectedIndex, value);
			}
		}

		public string SelectedItem
		{
			get { return selectedItem; }
			set
			{
				SetProperty(ref selectedItem, value);
			}
		}

		public DateTime SampleDate
		{
			get { return sampleDate; }
			set
			{
				SetProperty(ref sampleDate, value);
			}
		}

		public SampleModel()
		{
			SampleAction = new RelayCommands(SampleActionExecute);
			NewWindowAction = new RelayCommands(NewWindowActionExecute);
			DuplicateWindowAction = new RelayCommands(DuplicateWindowActionExecute);
			AddItemAction = new RelayCommands(AddItemActionExecute);

			SelectedIndex = 1;
			SampleDate = DateTime.Now;

			Items = new BindingList<HStringListItem>();
		}

		private void AddItemActionExecute(object obj)
		{
			Items.Add(new HStringListItem($"Item{Items.Count + 1}"));
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