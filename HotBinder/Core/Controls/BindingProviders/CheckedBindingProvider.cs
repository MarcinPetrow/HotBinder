using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	[ProvideProperty("CheckedBinding", typeof(CheckBox))]
	public class CheckedBindingProvider : Component, IExtenderProvider, IControlValueProvider<string>
	{
		private readonly Dictionary<Control, string> values;

		public CheckedBindingProvider()
		{
			values = new Dictionary<Control, string>();
		}

		public bool CanExtend(object extendee)
		{
			return extendee is CheckBox;
		}

		[Category("HotBinding")]
		[DisplayName("Checked")]
		public string GetCheckedBinding(Control ctl)
		{
			string value;
			if (values.TryGetValue(ctl, out value))
			{
				return value;
			}
			return "";
		}

		public void SetCheckedBinding(Control ctl, string value)
		{
			values[ctl] = value;
		}

		public string GetValue(Control control)
		{
			return GetCheckedBinding(control);
		}

		public void SetValue(Control control, string value)
		{
			SetCheckedBinding(control, value);
		}
	}
}