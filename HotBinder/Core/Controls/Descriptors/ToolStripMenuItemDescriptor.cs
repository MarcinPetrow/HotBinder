using HotBinder.Core.Attributes;
using HotBinder.Core.Controls.Descriptors;
using System.Windows.Forms;

namespace HotBinder.Core.Controls
{
	public class ToolStripMenuItemDescriptor : ControlDescriptor<ToolStripMenuItem>
	{
		public ToolStripMenuItemDescriptor()
		{
			DescriptedElements.Add(new BindableElement("Text", "TextChanged"));
		}
	}
}
