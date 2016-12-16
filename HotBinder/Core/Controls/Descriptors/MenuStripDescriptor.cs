using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{

	public class MenuStripDescriptor : ControlDescriptor<MenuStrip>
	{
		public string BindText { get; set; }

		public MenuStripDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Text", "TextChanged"));
		}
	}
}
