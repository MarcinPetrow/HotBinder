using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	[ProvideProperty("DataSourceBinding", typeof(Control))]
	public class DataSourceBindingProvider : Component, IExtenderProvider, IControlValueProvider<string>
	{
		private readonly Dictionary<Control, string> values;

		public DataSourceBindingProvider()
		{
			values = new Dictionary<Control, string>();
		}

		public bool CanExtend(object extendee)
		{
			return extendee is ComboBox || extendee is ListBox;
		}

		[Category("HotBinding")]
		[DisplayName("DataSource")]
		public string GetDataSourceBinding(Control ctl)
		{
			string value;
			if (values.TryGetValue(ctl, out value))
			{
				return value;
			}
			return "";
		}

		public void SetDataSourceBinding(Control ctl, string value)
		{
			values[ctl] = value;
		}

		public string GetValue(Control control)
		{
			return GetDataSourceBinding(control);
		}

		public void SetValue(Control control, string value)
		{
			SetDataSourceBinding(control, value);
		}
	}
}