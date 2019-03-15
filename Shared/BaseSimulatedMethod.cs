using System;

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

    // Пример создания метода с симуляцией нагрузки.

    public class CalculateLineSimulated : BaseSimulatedMethod
    {
        public CalculateLineData Param;

        public CalculateLineSimulated(CalculateLineData param) 
        {
            Param = param;

            Loading = 10;
            Time = 10;
        }

        public override object Process()
        {
            // Какая-то логика. 
            return 0;
        }
    }
}