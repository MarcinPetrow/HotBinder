using System.ComponentModel;
using System.Windows.Forms;
using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HPictureBox : PictureBox, IBindable
	{
		[Category("Model binding")]
		[BindableElement("Enabled", "EnabledChanged")]
		public string BindEnabled { get; set; }

		[Category("Model binding")]
		[BindableElement("Visible", "VisibleChanged")]
		public string BindVisible { get; set; }


		public Controller Context { get; set; }
	}
}
