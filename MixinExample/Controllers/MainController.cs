using HotBinder.Core;
using HotBinder.Core.Attributes;
using MixinExample.Views;

namespace MixinExample.Controllers
{
	[Controller(IsDefault = true)]
	public class MainController : Controller
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}

		[Action(IsDefault = true)]
		public void Index()
		{
			var view = new SimpleWPFView(this);

			Host.ApplyView(view);
		}

		[Action]
		public void Edition()
		{

		}
	}
}
