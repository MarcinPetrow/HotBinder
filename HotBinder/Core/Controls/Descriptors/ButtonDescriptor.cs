using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class ButtonDescriptor : ControlDescriptor<Button>
	{
		public ButtonDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Text", "TextChanged"));
		}
	}
}
