using System;

namespace BinderPlayground.Core
{
    public interface IContextable
    {
        ViewModel Context { get; set; }
    }
}