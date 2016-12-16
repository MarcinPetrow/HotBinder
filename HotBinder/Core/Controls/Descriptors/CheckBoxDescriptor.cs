using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class CheckBoxDescriptor : ControlDescriptor<CheckBox>
	{
		public CheckBoxDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Checked", "CheckedChanged"));
		}
	}
}
