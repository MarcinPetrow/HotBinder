using System.Windows.Forms;

namespace HotBinder.Core.Controls.BindingProviders
{
	public interface IControlValueProvider<T>
	{
		T GetValue(Control control);
		void SetValue(Control control, T value);
	}
}