using BinderPlayground.Core.Binding;
using System.ComponentModel;
using System.Windows.Forms;

namespace BinderPlayground.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HButton : Button, IBindable
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

		[Category("Model binding")]
		[BindableElement("Click", "Click", BindableType.Action)]
		public string ClickAction { get; set; }

		public ViewModel Context { get; set; }

		public HButton()
		{
			
		}
	}
}
