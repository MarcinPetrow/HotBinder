using HotBinder.Core.Attributes;
using HotBinder.Core.Binding;
using System.ComponentModel;
using System.Windows.Forms;
using HotBinder.Core.Abilities;

namespace HotBinder.Core.Controls
{
	[DesignerCategory("BindableInfo")]
	[ToolboxItem(true)]
	public class HComboBox : ComboBox, IBindable
	{
		[Category("Model binding")]
		[BindableElement("DataSource", "DataSourceChanged", BindableType.Collection)]
		public string BindDataSource { get; set; }

		[Category("Model binding")]
		[BindableElement("SelectedIndex", "SelectedIndexChanged")]
		public string BindSelectedIndex { get; set; }

		[Category("Model binding")]
		[BindableElement("SelectedItem", "SelectedIndexChanged")]
		public string BindSelectedItem { get; set; }

		[Category("Model binding")]
		[BindableElement("Enabled", "EnabledChanged")]
		public string BindEnabled { get; set; }

		[Category("Model binding")]
		[BindableElement("Visible", "VisibleChanged")]
		public string BindVisible { get; set; }

		[Category("Model binding")]
		[BindableElement("Click", "Click", BindableType.Action)]
		public string ClickAction { get; set; }

		public INotificator Context { get; set; }
	}
}
