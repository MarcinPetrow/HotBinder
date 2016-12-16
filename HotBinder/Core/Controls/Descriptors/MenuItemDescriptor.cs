using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class MenuItemDescriptor : ControlDescriptor<MenuItem>
	{
		public MenuItemDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Text", "TextChanged"));

		}
	}
}
