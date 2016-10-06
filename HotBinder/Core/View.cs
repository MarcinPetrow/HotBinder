using System;
using System.Linq;
using System.Windows.Forms;
using BinderPlayground.Core.Binding;

namespace BinderPlayground.Core
{
    public class View : UserControl
    {
        protected View()
        {
            
        }

        protected void InitializeView(Model model)
        {
            ApplyDataContext(model);
            Binder();
        }

        private void ApplyDataContext(Model model)
        {
            foreach (var contextable in Controls.OfType<IContextable>())
            {
                contextable.Context = model;
            }
            model.NotifyAllProperties();
        }

        private void Binder()
        {
            foreach (var bindable in from object control in Controls select control as IBindable)
            {
                bindable?.BindAll();
            }
        }
    }
}