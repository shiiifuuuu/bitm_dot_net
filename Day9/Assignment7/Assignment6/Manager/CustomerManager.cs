using Assignment6.REPOSITORY;
using System;
using System.Data;

namespace Assignment6.MANAGER
{
    public class CustomerManager
    {
        private CustomerRepository _customerRepository = new CustomerRepository();

        public bool AddCustomer(String name, String contact, String address)
        {
            return _customerRepository.AddCustomer(name, contact, address);
        }

        public DataTable SearchCustomer(String name)
        {
            return _customerRepository.SearchCustomer(name);
        }

        public bool UpdateCustomer(String name, String contact, String address, String id)
        {
            return _customerRepository.UpdateCustomer(name, contact, address, id);
        }

        public bool DeleteCustomer(String id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public DataTable ShowData()
        {
            return _customerRepository.ShowData();
        }

        public bool isCustomerExist(String name)
        {
            return _customerRepository.isCustomerExist(name);
        }
    }
}
