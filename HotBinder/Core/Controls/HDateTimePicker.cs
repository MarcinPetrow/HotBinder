using BinderPlayground.Core;
using BinderPlayground.Core.Binding;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HDateTimePicker : DateTimePicker, IBindable
	{
		[Category("Model binding")]
		[BindableElement("Value", "ValueChanged")]
		public string BindValue { get; set; }

		[Category("Model binding")]
		[BindableElement("Enabled", "EnabledChanged")]
		public string BindEnabled { get; set; }

		[Category("Model binding")]
		[BindableElement("Visible", "VisibleChanged")]
		public string BindVisible { get; set; }

		public ViewModel Context { get; set; }

		public HDateTimePicker()
		{
			this.ValueChanged += MDateTimePicker_ValueChanged;
		}

		private void MDateTimePicker_ValueChanged(object sender, System.EventArgs e)
		{
			//throw new System.NotImplementedException();
		}
	}
}
