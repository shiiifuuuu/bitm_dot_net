using Assignment6.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.MANAGER
{
    class ItemManager
    {
        private ItemRepository _itemRepository = new ItemRepository();

        public bool AddItem(String name, String price)
        {
            return _itemRepository.AddItem(name, price);
        }
        public bool IsItemExist(String name)
        {
            return _itemRepository.IsItemExist(name);
        }
        public DataTable SearchItem(String name)
        {
            return _itemRepository.SearchItem(name);
        }
        public bool UpdateItem(String name, String price, String id)
        {
            return _itemRepository.UpdateItem(name, price, id);
        }
        public bool DeleteItem(String id)
        {
            return _itemRepository.DeleteItem(id);
        }
        public DataTable ShowData()
        {
            return _itemRepository.ShowData();
        }
    }
}
