using BinderPlayground.Core;
using FileCopier.Models.App;
using FileCopier.Views;

namespace FileCopier.Controllers
{
	public class MainController : Controller
	{
		public void Index()
		{
			var model = new MainModel();
			var view = new MainView(model);

			Host.ApplyView(view);
		}
	}
}
