using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class TextBoxDescriptor : ControlDescriptor<TextBox>
	{
		public TextBoxDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Text", "TextChanged"));
		}
	}
}
