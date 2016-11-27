﻿using System;

namespace HotBinder.Core.Attributes
{
	public class ActionAttribute : Attribute
	{
		public bool IsDefault { get; set; }

		public ActionAttribute(bool isDefault = false)
		{
			IsDefault = isDefault;
		}
	}
}
