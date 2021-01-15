using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId) 
        {

            var customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Ahmet";
                customer.EmailAddress = "emal@email.com";
                customer.LastName = "Tach";
                customer.AddressList = addressRepository.RetriveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {

            return true;
        }
    }
}
