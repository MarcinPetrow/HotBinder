using System;
using System.Reflection;

namespace BinderPlayground.Core.Binding
{
    public class BindableInfo
    {
        public PropertyInfo PropertyInfo;
        public string PropertyName;
        public string UiEventName;
        public PropertyInfo UiPropertyInfo;
        public string UiPropertyName;
        public BindableType Type { get; set; }
    }
}