using HotBinder.Core.Attributes;
using System;
using System.Collections.Generic;

namespace HotBinder.Core.Controls.Descriptors
{
	public class ControlDescriptor<TControlType> : IControlDescriptor
	{
		protected readonly List<BindableElement> DescriptedElements;
		public Type DirectType => typeof(TControlType);

		public ControlDescriptor()
		{
			DescriptedElements = new List<BindableElement>
			{
				new BindableElement("Enabled", "EnabledChanged"),
				new BindableElement("Visible", "VisibleChanged"),
				new BindableElement("Click", "Click", BindableType.Action),
				new BindableElement("Size", "SizeChanged"),
			};
		}

		public List<BindableElement> GetBindableElements()
		{
			return DescriptedElements;
		}
	}
}