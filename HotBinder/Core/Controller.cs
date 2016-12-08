using HotBinder.Core.Abilities;
using HotBinder.Core.Keepers;

namespace HotBinder.Core
{
	public class Controller : Notificator
	{
		public AppHost Host;

		public void Redirect(string controllerName, string actionName)
		{
			var controller = ControllersKeeper.Instance.GetControllerEntry(controllerName);
			ControllersKeeper.Instance.InvokeAction(controller, actionName);
		}
	}
}