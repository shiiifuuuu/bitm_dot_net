using Assignment6.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.MANAGER
{
    class OrderManager
    {
        private OrderRepository _orderRepository = new OrderRepository();
        public DataTable ShowData()
        {
            return _orderRepository.ShowData();
        }
        public bool AddOrder(String name, String quantity, String price)
        {
            return _orderRepository.AddOrder(name, quantity, price);
        }
        public DataTable SearchOrder(String name)
        {
            return _orderRepository.SearchOrder(name);
        }
        public bool UpdateOrder(String name, String price, String quantity, String id)
        {
            return _orderRepository.UpdateOrder(name, price, quantity, id);
        }
        public bool DeleteOrder(String id)
        {
            return _orderRepository.DeleteOrder(id);
        }
    }
}
