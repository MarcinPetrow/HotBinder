using HotBinder.Core.Abilities;
using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HMenuStrip : MenuStrip, IBindable
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

		[Category("Model binding")]
		[BindableElement("Size", "SizeChanged")]
		public string BindSize { get; set; }


		public INotificator Context { get; set; }


	}
}
