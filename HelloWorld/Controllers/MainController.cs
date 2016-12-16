using HelloWorld.Views;
using HotBinder.Core;
using HotBinder.Core.Attributes;

namespace HelloWorld.Controllers
{
	[Controller(true)]
	public class MainController : Controller
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}

		[Action(true)]
		public void Index()
		{
			var view = new SimpleView(this);

			Name = "John";

			Host.ApplyView(view);
		}
	}
}
