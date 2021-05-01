using System;
using System.Reflection;

namespace FaceLikers
{
     public static class Singleton<T> where T : class
     {
          private static readonly object s_LockObj = new object();
          private static T s_Instance = null;

          public static T Instance
          {
               get
               {
                    if(s_Instance == null)
                    {
                         lock(s_LockObj)
                         {
                              if(s_Instance == null)
                              {
                                   ConstructorInfo[] constructors = typeof(T).GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
                                   s_Instance = (T)constructors[0].Invoke(null) as T;
                              }
                         }
                    }

                    return s_Instance;
               }
          }
     }
}
