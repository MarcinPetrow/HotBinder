using BinderPlayground.Core;

namespace BinderPlayground.App
{
	public class SampleController : Controller
	{
		public void Index()
		{
			var model = new SampleModel();
			var view = new SampleView(model);

			Host.ApplyView(view);

			model.Name = "Ex";
		}
	}
}