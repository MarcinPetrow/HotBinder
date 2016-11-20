using System;

namespace HotBinder.Core.Binding
{
    public class BindingException : Exception
    {
        public BindingException(string message) : base(message)
        {}
    }
}