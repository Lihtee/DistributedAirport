using System;
using System.Collections.Generic;

namespace Shared
{
    public abstract class BaseSimulatedMethod
    {
        /// <summary>
        ///     Нагрузка.
        /// </summary>
        public int Loading;

        /// <summary>
        ///     Время.
        /// </summary>
        public int Time;

        public abstract object Process();
    }

    

    
}