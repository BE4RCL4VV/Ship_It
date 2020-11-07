using System;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    //Shipping Cost $24.00
    class LawnMower : IShippable
    {
        public decimal ShipCost => 24.00M;

        public string Product => "Lawn Mower";
    
    }
}
