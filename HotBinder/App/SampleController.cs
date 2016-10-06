using System;
using BinderPlayground.Core;
using HotBinder;

namespace BinderPlayground.App
{
    public class SampleController : Controller
    {
        public void MakeATest(AppHost host)
        {
            var model = new SampleModel();
            var view = new SampleView(model);

            host.ApplyView(view);

            model.Name = "Ex";
        }
    }
}