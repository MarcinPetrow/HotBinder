using System;
using System.ComponentModel;
using System.Windows.Forms;
using BinderPlayground.Core.Binding;

namespace BinderPlayground.Core.Controls
{
    [ToolboxItem(true)]
    public class MTextBox : TextBox, IBindable
    {
        [Category("Model binding")]
        [BindableElement("Text", "TextChanged")]
        public string BindText { get; set; }

        [Category("Model binding")]
        [BindableElement("Enabled", "EnabledChanged")]
        public string BindEnabled { get; set; }

        [Category("Model binding")]
        [BindableElement("Visible", "VisibleChanged")]
        public string BindVisible { get; set; }

        public Model Context { get; set; }
    }
}