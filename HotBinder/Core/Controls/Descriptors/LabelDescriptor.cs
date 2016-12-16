using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class LabelDescriptor : ControlDescriptor<Label>
	{
		public LabelDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Text", "TextChanged"));
		}
	}
}
