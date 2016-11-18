using BinderPlayground.Core;
using HelloWorld.Models;
using HelloWorld.Views;

namespace HelloWorld.Controllers
{
	public class MainController : Controller
	{
		public void Index()
		{
			var model = new SimpleModel();
			var view = new SimpleView(model);

			Host.ApplyView(view);
		}
	}
}
