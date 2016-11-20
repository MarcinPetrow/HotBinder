using System.ComponentModel;
using System.Windows.Forms;
using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;

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

		public Controller Context { get; set; }

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
