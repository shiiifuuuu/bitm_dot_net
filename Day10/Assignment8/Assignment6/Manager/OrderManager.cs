using Assignment6.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment6.MODEL;

namespace Assignment6.MANAGER
{
    class OrderManager
    {
        private OrderRepository _orderRepository = new OrderRepository();
        public DataTable ShowData()
        {
            return _orderRepository.ShowData();
        }
        public bool AddOrder(Order _order)
        {
            return _orderRepository.AddOrder(_order);
        }
        public DataTable SearchOrder(Order _order)
        {
            return _orderRepository.SearchOrder(_order);
        }
        public bool UpdateOrder(Order _order)
        {
            return _orderRepository.UpdateOrder(_order);
        }
        public bool DeleteOrder(Order _order)
        {
            return _orderRepository.DeleteOrder(_order);
        }
        public DataTable ItemComboShow()
        {
            return _orderRepository.ItemComboShow();
        }
        public DataTable CustomerComboShow()
        {
            return _orderRepository.CustomerComboShow();
        }
    }
}
