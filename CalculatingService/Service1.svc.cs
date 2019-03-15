using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Shared;

namespace CalculatingService
{
    public class CalculatingService : ICalculatingService
    {
        public int CalculateLine(CalculateLineData value)
        {
            throw new NotImplementedException();
        }
    }
}
