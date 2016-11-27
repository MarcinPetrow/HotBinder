using System;

namespace HotBinder.Core.Attributes
{
	public class ControllerAttribute : Attribute
	{
		public bool IsDefault { get; set; }

		public ControllerAttribute(bool isDefault = false)
		{
			IsDefault = isDefault;
		}
	}
}
