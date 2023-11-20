using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_First_Look.Business.Strategies
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}
