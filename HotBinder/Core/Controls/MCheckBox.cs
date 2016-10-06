using System;
using System.ComponentModel;
using System.Windows.Forms;
using BinderPlayground.Core.Binding;

namespace BinderPlayground.Core.Controls
{
    [DesignerCategory("BindableInfo")]
    [ToolboxItem(true)]
    public class MCheckBox : CheckBox, IBindable
    {
        [Category("Model binding")]
        [BindableElement("Checked", "CheckedChanged")]
        public string BindChecked { get; set; }

        [Category("Model binding")]
        [BindableElement("Enabled", "EnabledChanged")]
        public string BindEnabled { get; set; }

        [Category("Model binding")]
        [BindableElement("Visible", "VisibleChanged")]
        public string BindVisible { get; set; }

        public Model Context { get; set; }
    }
}