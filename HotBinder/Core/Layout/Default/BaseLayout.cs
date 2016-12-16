using HotBinder.Core.Binding;
using HotBinder.Core.Keepers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HotBinder.Core.Layout.Default
{
	public class BaseLayout : UserControl, ILayout
	{
		private AppHost appHost;

		public void InitializeLayout(AppHost host)
		{
			appHost = host;

			ApplyDataContext();
			Binder();
		}

		public virtual ViewHost GetViewContainer()
		{
			throw new NullReferenceException("No appHost defined for this layout!");
		}

		public void Redirect(string controllerName, string actionName)
		{
			var controller = ControllersKeeper.Instance.GetControllerEntry(controllerName);
			ControllersKeeper.Instance.InvokeAction(controller, actionName);
		}

		public void ChangeLayout(string layoutName)
		{
			appHost.ChangeLayout(layoutName);
		}

		private void ApplyDataContext(Control target = null)
		{
			ContextsKeeper.Instance.Register(this, this);

			NotifyAllProperties();
		}

		private void Binder(Control target = null)
		{
			ControlCollection controlsList = target?.Controls ?? Controls;

			foreach (var control in controlsList)
			{
				if (control is ViewHost)
				{
					continue;
				}
				var bindable = control as Control;
				//BindingHelper.BindAll(this, bindable);
				Console.WriteLine($"Binder on {bindable}");
			}

			for (var index = 0; index < controlsList.Count; index++)
			{
				var control = controlsList[index];
				if (control is ViewHost)
				{
					continue;
				}
				Binder(control);
			}


		}

		#region Notificator

		public void NotifyAllProperties()
		{
			foreach (var propertyInfo in GetType().GetProperties())
			{
				if (!propertyInfo.CanRead)
				{
					continue;
				}
				var propertyName = propertyInfo.Name;
				OnPropertyChanged(propertyName);
			}
		}

		public void NotifyProperty([CallerMemberName]string propertyName = null)
		{
			OnPropertyChanged(propertyName);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value))
			{
				return;
			}

			field = value;
			NotifyProperty(propertyName);
		}

		#endregion

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// BaseLayout
			// 
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Name = "BaseLayout";
			this.Size = new System.Drawing.Size(0, 0);
			this.ResumeLayout(false);

		}
	}
}