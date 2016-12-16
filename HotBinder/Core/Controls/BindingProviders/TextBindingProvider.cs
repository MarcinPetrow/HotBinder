using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	[ProvideProperty("TextBinding", typeof(Control))]
	public class TextBindingProvider : Component, IExtenderProvider, IControlValueProvider<string>
	{
		private readonly Dictionary<Control, string> values;

		public TextBindingProvider()
		{
			values = new Dictionary<Control, string>();
		}

		public bool CanExtend(object extendee)
		{
			return extendee is TextBox;
		}

		[Category("HotBinding")]
		[DisplayName("Text")]
		public string GetTextBinding(Control ctl)
		{
			string value;
			if (values.TryGetValue(ctl, out value))
			{
				return value;
			}
			return "";
		}

		public void SetTextBinding(Control ctl, string value)
		{
			values[ctl] = value;
		}

		public string GetValue(Control control)
		{
			return GetTextBinding(control);
		}

		public void SetValue(Control control, string value)
		{
			SetTextBinding(control, value);
		}
	}
}