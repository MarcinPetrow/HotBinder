using System.Reflection;
using HotBinder.Core.Attributes;

namespace HotBinder.Core.Keepers
{
	public class ActionEntry
	{
		public string Name { get; set; }
		public bool Default { get; set; }
		public MethodInfo Method { get; set; }

		public ActionEntry(MethodInfo method, ActionAttribute controllerActionAttribute)
		{
			Method = method;
			Name = method.Name;
			Default = controllerActionAttribute?.IsDefault ?? false;
		}

		public void Execute(Controller scope)
		{
			Method?.Invoke(scope, null);
		}
	}
}