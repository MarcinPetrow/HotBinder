using BinderPlayground.Core;
using BinderPlayground.Core.Binding;
using System.ComponentModel;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class MNumericUpDown : NumericUpDown, IBindable
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


		public Model Context { get; set; }

	}
}
