using BinderPlayground.Core;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

namespace BinderPlayground.App
{
	public class DummyItem : IConvertible
	{
		public string Value;

		public DummyItem(string value)
		{
			Value = value;
		}

		public TypeCode GetTypeCode()
		{
			throw new NotImplementedException();
		}

		public bool ToBoolean(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public byte ToByte(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public char ToChar(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public DateTime ToDateTime(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public decimal ToDecimal(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public double ToDouble(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public short ToInt16(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public int ToInt32(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public long ToInt64(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public sbyte ToSByte(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public float ToSingle(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public string ToString(IFormatProvider provider)
		{
			return Value;
		}

		public override string ToString()
		{
			return ToString(null);
		}

		public object ToType(Type conversionType, IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public ushort ToUInt16(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public uint ToUInt32(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}

		public ulong ToUInt64(IFormatProvider provider)
		{
			throw new NotImplementedException();
		}
	}

	public class SampleModel : Model
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
		private BindingList<DummyItem> items;
		private int selectedIndex;
		private string selectedItem;

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

		public BindingList<DummyItem> Items
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

		public SampleModel()
		{
			SampleAction = new RelayCommands(SampleActionExecute);
			NewWindowAction = new RelayCommands(NewWindowActionExecute);
			DuplicateWindowAction = new RelayCommands(DuplicateWindowActionExecute);
			AddItemAction = new RelayCommands(AddItemActionExecute);

			SelectedIndex = 1;

			Items = new BindingList<DummyItem>();
		}

		private void AddItemActionExecute(object obj)
		{
			Items.Add(new DummyItem($"Item{Items.Count + 1}"));
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