using Assignment6.REPOSITORY;
using System;
using System.Data;
using Assignment6.MODEL;
using System.Collections.Generic;

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

        public List<Customer> ShowData()
        {
            return _customerRepository.ShowData();
        }

        public bool isCodeExist(Customer _customer)
        {
            return _customerRepository.isCodeExist(_customer);
        }

        public bool isContactExist(Customer _customer)
        {
            return _customerRepository.isContactExist(_customer);
        }

        public string findId(string customerCode)
        {
            return _customerRepository.findId(customerCode);
        }

        public void CloseConnection()
        {
            _customerRepository.CloseConnection();
        }
    }
}
