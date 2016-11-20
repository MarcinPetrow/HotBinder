using System;

namespace HotBinder.Core.Attributes
{
	public class BindableElement : Attribute
	{
		public BindableElement(string name, string eventName, BindableType type = BindableType.Data)
		{
			Name = name;
			EventName = eventName;
			Type = type;
		}

		public BindableElement(string name)
		{
			Name = name;
		}

		public string Name { get; }
		public string EventName { get; }

		public BindableType Type { get; }
	}

	public enum BindableType
	{
		Data,
		Action,
		Collection
	}
}