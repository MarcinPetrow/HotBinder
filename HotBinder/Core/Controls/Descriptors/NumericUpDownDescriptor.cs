using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class NumericUpDownDescriptor : ControlDescriptor<NumericUpDown>
	{
		public NumericUpDownDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Value", "ValueChanged"));
		}
	}
}
