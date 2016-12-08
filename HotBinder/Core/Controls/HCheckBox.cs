using HotBinder.Core.Abilities;
using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HCheckBox : CheckBox, IBindable
	{
		[Category("Model binding")]
		[BindableElement("Checked", "CheckedChanged")]
		public string BindChecked { get; set; }

		[Category("Model binding")]
		[BindableElement("Enabled", "EnabledChanged")]
		public string BindEnabled { get; set; }

		[Category("Model binding")]
		[BindableElement("Visible", "VisibleChanged")]
		public string BindVisible { get; set; }

		public INotificator Context { get; set; }
	}
}