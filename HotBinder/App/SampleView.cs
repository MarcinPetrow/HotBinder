using System;
using BinderPlayground.Core;

namespace BinderPlayground.App
{
    public partial class SampleView : View
    {
        public SampleView(Model model)
        {
            InitializeComponent();
            InitializeView(model);
        }
    }
}