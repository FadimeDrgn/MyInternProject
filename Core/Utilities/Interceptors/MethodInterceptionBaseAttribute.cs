using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        //Priority: hangisi önce çalışsın? Öncelik değeri
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
