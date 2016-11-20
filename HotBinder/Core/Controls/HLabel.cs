using System.ComponentModel;
using System.Windows.Forms;
using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HLabel : Label, IBindable
	{
		[Category("Model binding")]
		[BindableElement("Text", "TextChanged")]
		public string BindText { get; set; }

		[Category("Model binding")]
		[BindableElement("Enabled", "EnabledChanged")]
		public string BindEnabled { get; set; }

		[Category("Model binding")]
		[BindableElement("Visible", "VisibleChanged")]
		public string BindVisible { get; set; }

		public Controller Context { get; set; }
	}
}
