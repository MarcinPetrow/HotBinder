using HotBinder.Core.Attributes;
using System.Windows.Forms;

namespace HotBinder.Core.Controls.Descriptors
{
	public class TrackBarDescriptor : ControlDescriptor<TrackBar>
	{
		public TrackBarDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Value", "ValueChanged"));
			DescriptedElements.Add(new BindableElement("Minimum"));
			DescriptedElements.Add(new BindableElement("Maximum"));
		}
	}
}
