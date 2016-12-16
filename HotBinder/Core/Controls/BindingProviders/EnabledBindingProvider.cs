using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	[ProvideProperty("EnabledBinding", typeof(Control))]
	public class EnabledBindingProvider : Component, IExtenderProvider, IControlValueProvider<string>
	{
		private readonly Dictionary<Control, string> values;

		public EnabledBindingProvider()
		{
			values = new Dictionary<Control, string>();
		}

		public bool CanExtend(object extendee)
		{
			return true;
		}

		[Category("HotBinding")]
		[DisplayName("Enabled")]
		public string GetEnabledBinding(Control ctl)
		{
			string value;
			if (values.TryGetValue(ctl, out value))
			{
				return value;
			}
			return "";
		}

		public void SetEnabledBinding(Control ctl, string value)
		{
			values[ctl] = value;
		}

		public string GetValue(Control control)
		{
			return GetEnabledBinding(control);
		}

		public void SetValue(Control control, string value)
		{
			SetEnabledBinding(control, value);
		}
	}
}