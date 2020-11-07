using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    //Shipping Cost $20.50
    class Bicycle : IShippable
    {
        public decimal ShipCost => 20.50M;
        public string Product => "Bicycle";
    }
}
