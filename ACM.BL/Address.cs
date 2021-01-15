using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {
                
        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }
        public int AddressId { get; private set; }

        public bool Validate()
        {
            bool isValid = true;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
