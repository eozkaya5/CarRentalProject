using System;

namespace Entities.Concrete
{
    //[AttributeUsage(AttributeTargets.Class)]// Sadece class'larda kullanabilrsin
    // nerede kullanabileceğimizi belirleyebiliriz
    //[AttributeUsage(AttributeTargets.Class ,AllowMultiple =true)]// Birden fazla kullanbilir miyiz


    [AttributeUsage(AttributeTargets.All)]// her yerde kullanabilirsin
    internal class RequiredPropertyAttribute : Attribute
    {
        // Attribute  oluşturuldu
    }
}