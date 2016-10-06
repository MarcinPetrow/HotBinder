using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinderPlayground.Core.Binding;

namespace BinderPlayground.Core.Controls
{
    [DesignerCategory("BindableInfo")]
    [ToolboxItem(true)]
    public class MButton: Button, IBindable
    {
        [Category("Model binding")]
        [BindableElement("Text", "TextChanged")]
        public string TextChecked { get; set; }

        [Category("Model binding")]
        [BindableElement("Enabled", "EnabledChanged")]
        public string BindEnabled { get; set; }

        [Category("Model binding")]
        [BindableElement("Visible", "VisibleChanged")]
        public string BindVisible { get; set; }

        [Category("Model binding")]
        [BindableElement("Click", "Click", BindableType.Action)]
        public string ClickAction { get; set; }

        public Model Context { get; set; }
    }
}
