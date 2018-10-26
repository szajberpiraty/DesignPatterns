using System;
using System.Collections.Generic;

namespace _01Adapter
{
    public class AddressRepository
    {
        public AddressRepository()
        {
        }

        public IList<Address> GetAddresses()
        {
            var fakalist = new List<Address>();
            var addr = new Address { Email = "valami" };
            fakalist.Add(addr);

            //return new List<Address>(new Address {Email="valaki" });
            return fakalist;
        }
    }

   
}