using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Shared
{
    [DataContract]
    public class CalculateLineData
    {
        [DataMember]
        public List<Line> Lines;

        [DataMember]
        public Plane Plane;
    }

    /// <summary>
    ///     Заглушка для самолета.
    /// </summary>
    [DataContract]
    public class Plane
    {
    }

    [DataContract]
    public class Line
    {
        [DataMember]
        public int Nmber;

        [DataMember]
        public tState State;
    }

    // ReSharper disable once InconsistentNaming
    public enum tState
    {
        /// <summary>
        ///     Свободна.
        /// </summary>
        Free = 1,

        /// <summary>
        ///     Занята.
        /// </summary>
        Busy = 2
    }
}