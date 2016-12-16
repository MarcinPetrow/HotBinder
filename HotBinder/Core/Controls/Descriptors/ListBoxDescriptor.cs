using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class ListBoxDescriptor : ControlDescriptor<ListBox>
	{
		public ListBoxDescriptor()
		{
			DescriptedElements.Add(new BindableElement("DataSource", "DataSourceChanged", BindableType.Collection));
			DescriptedElements.Add(new BindableElement("SelectedIndex", "SelectedIndexChanged"));
			DescriptedElements.Add(new BindableElement("SelectedItem", "SelectedIndexChanged"));
		}

	}
}

