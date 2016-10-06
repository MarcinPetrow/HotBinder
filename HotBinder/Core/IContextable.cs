using System;

namespace BinderPlayground.Core
{
    public interface IContextable
    {
        Model Context { get; set; }
    }
}