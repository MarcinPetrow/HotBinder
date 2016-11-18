using BinderPlayground.Core;

namespace HelloWorld.Models
{
	public class SimpleModel : ViewModel
	{
		private string name;

		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}

	}
}
