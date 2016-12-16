using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class ProgressBarDescriptor : ControlDescriptor<ProgressBar>
	{
		public ProgressBarDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Value"));
			DescriptedElements.Add(new BindableElement("Minimum"));
			DescriptedElements.Add(new BindableElement("Maximum"));
		}
	}
}
