using System;

namespace BinderPlayground.Core.Binding
{
    public class BindingException : Exception
    {
        public BindingException(string message) : base(message)
        {}
    }
}