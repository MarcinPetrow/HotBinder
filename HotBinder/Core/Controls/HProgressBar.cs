using System.ComponentModel;
using System.Windows.Forms;
using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HProgressBar : ProgressBar, IBindable
	{
		[Category("Model binding")]
		[BindableElement("Value")]
		public string BindValue { get; set; }

		[Category("Model binding")]
		[BindableElement("Minimum")]
		public string BindMinimum { get; set; }

		[Category("Model binding")]
		[BindableElement("Maximum")]
		public string BindMaximum { get; set; }

		[Category("Model binding")]
		[BindableElement("Enabled", "EnabledChanged")]
		public string BindEnabled { get; set; }

		[Category("Model binding")]
		[BindableElement("Visible", "VisibleChanged")]
		public string BindVisible { get; set; }


		public Controller Context { get; set; }

		public HProgressBar()
		{
		}
	}
}
