using HotBinder.Core.Controls;
using HotBinder.Core.Controls.Descriptors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotBinder.Core.Keepers
{
	public class DescriptorsKeepers
	{
		#region Singleton

		private static volatile DescriptorsKeepers instance;
		private static readonly object SyncRoot = new object();

		private DescriptorsKeepers()
		{
			InitializeDescriptors();
		}

		public static DescriptorsKeepers Instance
		{
			get
			{
				if (instance == null)
				{
					lock (SyncRoot)
					{
						if (instance == null)
						{
							instance = new DescriptorsKeepers();
						}
					}
				}

				return instance;
			}
		}

		#endregion Singleton

		private Dictionary<Type, IControlDescriptor> descriptors;

		private void InitializeDescriptors()
		{
			descriptors = new Dictionary<Type, IControlDescriptor>();
			descriptors.Add(typeof(Button), new ButtonDescriptor());
			descriptors.Add(typeof(TextBox), new TextBoxDescriptor());
			descriptors.Add(typeof(CheckBox), new CheckBoxDescriptor());
			descriptors.Add(typeof(ProgressBar), new ProgressBarDescriptor());
			descriptors.Add(typeof(PictureBox), new PictureBoxDescriptor());
			descriptors.Add(typeof(DateTimePicker), new DateTimePickerDescriptor());
			descriptors.Add(typeof(ComboBox), new ComboBoxDescriptor());
			descriptors.Add(typeof(TrackBar), new TrackBarDescriptor());
			descriptors.Add(typeof(RadioButton), new RadioButtonDescriptor());
			descriptors.Add(typeof(NumericUpDown), new NumericUpDownDescriptor());
			descriptors.Add(typeof(ListBox), new ListBoxDescriptor());
			descriptors.Add(typeof(Label), new LabelDescriptor());
		}

		public IControlDescriptor GetDescriptor(Type controlType)
		{
			if (descriptors.ContainsKey(controlType))
			{
				return descriptors[controlType];
			}

			return null;
		}
	}
}
