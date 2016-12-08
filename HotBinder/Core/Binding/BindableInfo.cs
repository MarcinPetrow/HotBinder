using HotBinder.Core.Abilities;
using HotBinder.Core.Attributes;
using System.Reflection;

namespace HotBinder.Core.Binding
{
	public class BindableInfo
	{
		public PropertyInfo PropertyInfo;
		public string PropertyName;
		public string UiEventName;
		public PropertyInfo UiPropertyInfo;
		public string UiPropertyName;

		public INotificator Context { get; internal set; }
		public BindableType Type { get; set; }
	}
}