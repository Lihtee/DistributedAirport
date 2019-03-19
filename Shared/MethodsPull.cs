using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Shared
{
     /// <summary>
     /// Пул симуляционных методов.
     /// </summary>
    public class MethodsPull
    {
        private List<BaseSimulatedMethod> methods;

        public MethodsPull()
        {
            methods = new List<BaseSimulatedMethod>();
        }

        public object ExecuteMethod(BaseSimulatedMethod bsm)
        {
            methods.Add(bsm);
            object result = bsm.Process();
            Thread.Sleep(1000 * bsm.Time);
            methods.Remove(bsm);
            return result;
        }

        /// <summary>
        /// Возвращает сумму нагрузок выполняемых методов.
        /// </summary>
        public int GetLoading()
        {
            return methods.Sum(x => x.Loading);
        }

        public List<string> GetMethodList()
        {
            return methods.Select(x => x.Name).ToList();
        }
    }
}