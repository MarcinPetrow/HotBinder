using HelloWorld.Views;
using HotBinder.Core;
using HotBinder.Core.Attributes;

namespace HelloWorld.Controllers
{
	public class MainController : Controller
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}

		[Action]
		public void Index()
		{
			var view = new SimpleView(this);

			Host.ApplyView(view);
		}
	}
}
