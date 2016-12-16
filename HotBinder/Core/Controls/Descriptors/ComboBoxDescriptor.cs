using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class ComboBoxDescriptor : ControlDescriptor<ComboBox>
	{
		public ComboBoxDescriptor()
		{
			DescriptedElements.Add(new BindableElement("DataSource", "DataSourceChanged", BindableType.Collection));
			DescriptedElements.Add(new BindableElement("SelectedIndex", "SelectedIndexChanged"));
			DescriptedElements.Add(new BindableElement("SelectedItem", "SelectedIndexChanged"));
		}
	}
}
