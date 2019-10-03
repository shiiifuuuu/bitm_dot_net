using Assignment6.REPOSITORY;
using System;
using System.Data;
using Assignment6.MODEL;

namespace Assignment6.MANAGER
{
    public class CustomerManager
    {
        private CustomerRepository _customerRepository = new CustomerRepository();

        public bool AddCustomer(Customer _customer)
        {
            return _customerRepository.AddCustomer(_customer);
        }

        public DataTable SearchCustomer(String searchText)
        {
            return _customerRepository.SearchCustomer(searchText);
        }

        public bool UpdateCustomer(Customer _customer)
        {
            return _customerRepository.UpdateCustomer(_customer);
        }

        public bool DeleteCustomer(Customer _customer)
        {
            return _customerRepository.DeleteCustomer(_customer);
        }

        public DataTable ShowData()
        {
            return _customerRepository.ShowData();
        }

        public bool isCustomerExist(Customer _customer)
        {
            return _customerRepository.isCustomerExist(_customer);
        }
    }
}
