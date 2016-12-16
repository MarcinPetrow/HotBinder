using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	[ProvideProperty("VisibleBinding", typeof(Control))]
	public class VisibleBindingProvider : Component, IExtenderProvider, IControlValueProvider<string>
	{
		private readonly Dictionary<Control, string> values;

		public VisibleBindingProvider()
		{
			values = new Dictionary<Control, string>();
		}

		public bool CanExtend(object extendee)
		{
			return true;
		}

		[Category("HotBinding")]
		[DisplayName("Visible")]
		public string GetVisibleBinding(Control ctl)
		{
			string value;
			if (values.TryGetValue(ctl, out value))
			{
				return value;
			}
			return "";
		}

		public void SetVisibleBinding(Control ctl, string value)
		{
			values[ctl] = value;
		}

		public string GetValue(Control control)
		{
			return GetVisibleBinding(control);
		}

		public void SetValue(Control control, string value)
		{
			SetVisibleBinding(control, value);
		}
	}
}