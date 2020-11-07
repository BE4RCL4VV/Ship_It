using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    //Shipping Cost $.57
    class Cracker : IShippable
    {
        public decimal ShipCost => .57M;

        public string Product => "Crackers";
    
    }
}
