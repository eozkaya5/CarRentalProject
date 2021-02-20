using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }


        public override void Intercept(IInvocation invocation)//Methodları çalışmadan önce burası kullanılacak
        {
            //nerede çalıştırmak istersin
            var isSuccess = true;
            OnBefore(invocation);//başında
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);//hata aldığında
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);//başarılı olduğunda
                }
            }
            OnAfter(invocation);// sonunda
        }

    }
}
