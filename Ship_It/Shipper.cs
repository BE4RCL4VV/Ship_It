using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ship_It
{
    class Shipper<T>
    {
        // List<T> for internal Storage
        
        private List<T> _shipment= new List<T>();
        public Shipper() { }
        private int count { get; }

        public List<T> Add(T Product)
        {
            _shipment.Add(Product);
            return _shipment;
        }

        public List<T> ShipmentTotal
        {
            get { return _shipment; }
        }


    }
}
