using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    //Shipping Cost $3.23
    class BaseballGlove : IShippable
    {
        public decimal ShipCost => 3.23M;

        public string Product => "Baseball Glove";
    
    }
}
