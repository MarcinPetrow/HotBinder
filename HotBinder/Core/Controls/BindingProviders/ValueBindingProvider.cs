using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	[ProvideProperty("ValueBinding", typeof(Control))]
	public class ValueBindingProvider : Component, IExtenderProvider, IControlValueProvider<string>
	{
		private readonly Dictionary<Control, string> values;

		public ValueBindingProvider()
		{
			values = new Dictionary<Control, string>();
		}

		public bool CanExtend(object extendee)
		{
			return extendee is ProgressBar || extendee is TrackBar || extendee is NumericUpDown || extendee is DateTimePicker;
		}

		[Category("HotBinding")]
		[DisplayName("Value")]
		public string GetValueBinding(Control ctl)
		{
			string value;
			if (values.TryGetValue(ctl, out value))
			{
				return value;
			}
			return "";
		}

		public void SetValueBinding(Control ctl, string value)
		{
			values[ctl] = value;
		}

		public string GetValue(Control control)
		{
			return GetValueBinding(control);
		}

		public void SetValue(Control control, string value)
		{
			SetValueBinding(control, value);
		}
	}
}