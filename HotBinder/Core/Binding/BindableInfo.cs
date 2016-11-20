using System.Reflection;
using HotBinder.Core.Attributes;

namespace HotBinder.Core.Binding
{
	public class BindableInfo
	{
		public PropertyInfo PropertyInfo;
		public string PropertyName;
		public string UiEventName;
		public PropertyInfo UiPropertyInfo;
		public string UiPropertyName;

		public Controller Context { get; internal set; }
		public BindableType Type { get; set; }
	}
}