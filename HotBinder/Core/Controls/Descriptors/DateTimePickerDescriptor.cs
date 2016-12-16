using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class DateTimePickerDescriptor : ControlDescriptor<DateTimePicker>
	{
		public DateTimePickerDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Value", "ValueChanged"));
		}
	}
}
