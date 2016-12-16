using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class RadioButtonDescriptor : ControlDescriptor<RadioButton>
	{
		public RadioButtonDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Checked", "CheckedChanged"));
		}
	}
}
