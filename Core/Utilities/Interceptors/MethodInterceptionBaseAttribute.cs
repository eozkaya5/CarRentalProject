using Castle.Components.DictionaryAdapter;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple =true, Inherited =true)]
    public abstract class MethodInterceptionBaseAttribute: Attribute,IInterceptor
    {
        public int Priority { get; set; }//Öncelik anlamına gelir
   
        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
