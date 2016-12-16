using System;
using System.Collections.Generic;
using HotBinder.Core.Attributes;

namespace HotBinder.Core.Controls.Descriptors
{
	public interface IControlDescriptor
	{
		Type DirectType { get; }
		List<BindableElement> GetBindableElements();
	}
}