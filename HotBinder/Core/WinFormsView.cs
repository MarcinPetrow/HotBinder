using HotBinder.Core.Binding;
using HotBinder.Core.Controls.BindingProviders;
using HotBinder.Core.Keepers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotBinder.Core
{
	public class WinFormsView : UserControl, IView
	{
		#region Binding Provider

		protected CheckedBindingProvider CheckedBindingProvider = new CheckedBindingProvider();
		protected TextBindingProvider TextBindingProvider = new TextBindingProvider();
		protected EnabledBindingProvider EnabledBindingProvider = new EnabledBindingProvider();
		protected VisibleBindingProvider VisibleBindingProvider = new VisibleBindingProvider();
		protected ValueBindingProvider ValueBindingProvider = new ValueBindingProvider();
		protected ClickBindingProvider ClickBindingProvider = new ClickBindingProvider();
		protected DataSourceBindingProvider DataSourceBindingProvider = new DataSourceBindingProvider();

		protected Dictionary<string, IControlValueProvider<string>> ValueProviders;

		#endregion

		public WinFormsView()
		{
			InitializeComponent();
			ValueProviders = new Dictionary<string, IControlValueProvider<string>>
			{
				{"Text", TextBindingProvider},
				{"Checked", CheckedBindingProvider},
				{"Enabled", EnabledBindingProvider},
				{"Visible", VisibleBindingProvider},
				{"Value", ValueBindingProvider },
				{"Click", ClickBindingProvider },
				{"DataSource", DataSourceBindingProvider }
			};
		}

		public void InitializeView(Controller controllerContext)
		{
			ApplyDataContext(controllerContext);
			Binder();
		}

		private void ApplyDataContext(Controller controllerContext)
		{
			ContextsKeeper.Instance.Register(this, controllerContext);

			controllerContext.NotifyAllProperties();
		}

		private void Binder()
		{
			foreach (var control in Controls)
			{
				BindingHelper.BindAll(this, control as Control);
			}
		}

		private void InitializeComponent()
		{
			SuspendLayout();
			// 
			// WinFormsView
			// 
			Name = "WinFormsView";
			ResumeLayout(false);

		}

		public IControlValueProvider<string> GetValueProvider(string name)
		{
			try
			{
				return ValueProviders[name];
			}
			catch
			{
				return null;
			}
		}
	}
}