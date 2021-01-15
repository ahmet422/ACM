using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrive(int addressId)
        {
            var address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.Street1 = "Foster ave";
                address.Street2 = "Lexington dr";
                address.City = "Chicago";
                address.State = "Illinois";
                address.Country = "USA";
                address.PostalCode = "303220";
            }
            return address;
        }

        public IEnumerable<Address> RetriveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            var adress = new Address(1)
            {
                AddressType = 1,
                Street1 = "Foster ave",
                Street2 = "Lexington dr",
                City = "Chicago",
                State = "Illinois",
                Country = "USA",
                PostalCode = "303220"
            };

            addressList.Add(adress);

            adress = new Address(2)
            {
                AddressType = 2,
                Street1 = "Michigan ave",
                Street2 = "Judge dr",
                City = "Chicago",
                State = "Illinois",
                Country = "USA",
                PostalCode = "302120"
            };
            addressList.Add(adress);

            return addressList;
        }
        public bool Save()
        {
            return true;
        }
    }
}
